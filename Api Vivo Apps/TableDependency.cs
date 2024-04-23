using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using Shared_Static_Class.Data;
using Vivo_Apps_API.Hubs;
using Shared_Static_Class.DB_Context_Vivo_MAIS;
using TableDependency.SqlClient.Base;
using System.Data.Entity;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Timers;
using Timer = System.Timers.Timer;
using Blazorise;
using TableDependency.SqlClient.Base.Messages;

namespace Vivo_Apps_API
{
    public class TableDependencyService
    {
        private IDbContextFactory<DemandasContext> DbFactory;
        private DemandasContext Demanda_BD;
        private readonly ISuporteDemandaHub _HubContext;
        private readonly SqlTableDependency<DEMANDA_CHAMADO> _dependency;
        Timer _timer;
        bool _canTrigger = true;

        public TableDependencyService(ISuporteDemandaHub HubContext, IDbContextFactory<DemandasContext> dbContextFactory)
        {
            DbFactory = dbContextFactory;
            Demanda_BD = DbFactory.CreateDbContext();
            _HubContext = HubContext;
            _dependency = new SqlTableDependency<DEMANDA_CHAMADO>(Demanda_BD.Database.GetConnectionString(), "DEMANDA_CHAMADO", "Demandas");
            _dependency.OnChanged += TableDependency_OnChanged;
            _dependency.OnError += TableDependency_OnError;
            _dependency.Start();

            _timer = new Timer(5000); // 5 seconds
            _timer.Elapsed += OnTimerElapsed;
            _timer.AutoReset = false; // Only trigger once
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _canTrigger = true;
        }

        private async void TableDependency_OnChanged(object sender, RecordChangedEventArgs<DEMANDA_CHAMADO> e)
        {
            if (e.ChangeType == TableDependency.SqlClient.Base.Enums.ChangeType.Insert)
            {
                if (_canTrigger)
                {
                    _canTrigger = false;
                    _timer.Start();
                    await _HubContext.SendTableDemandas();
                    var user = Demanda_BD.ACESSOS_MOBILE.Where(x => x.MATRICULA == e.Entity.MATRICULA_SOLICITANTE).FirstOrDefault();
                    _HubContext.NewNotification( 
                        user.NOME
                        , "Nova demanda aberta"
                        , $"Uma nova boleta acabou de ser gerada por {user.NOME}, com o número {e.Entity.ID}"
                        , $"/consultar/consultardemandasbyid/{e.Entity.ID}", user.REGIONAL);
                }
            }
        }

        private void TableDependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            Console.WriteLine($"{nameof(DEMANDA_CHAMADO)} SqlTableDependency error: {e.Error.Message}");
        }
    }
}
