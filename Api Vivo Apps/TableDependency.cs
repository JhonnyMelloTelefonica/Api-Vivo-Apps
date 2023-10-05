using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using Shared_Class_Vivo_Mais.Data;
using Vivo_Apps_API.Hubs;
using Shared_Class_Vivo_Mais.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API
{
    public class TableDependencyService
    {
        Vivo_MAISContext _context = new();
        private readonly IHubContext<VivoXHub> HubContext;
        private readonly SqlTableDependency<ACESSOS_MOBILE> _dependency;

        public TableDependencyService(IHubContext<VivoXHub> hubContext)
        {
            this.HubContext = hubContext; 
            _dependency = new SqlTableDependency<ACESSOS_MOBILE>(_context.Database.GetConnectionString(), "ACESSOS_MOBILE");
            _dependency.OnChanged += Changed;
            _dependency.Start();
        }

        private async void Changed(object sender, RecordChangedEventArgs<ACESSOS_MOBILE> e)
        {
            if (e.ChangeType.HasFlag(TableDependency.SqlClient.Base.Enums.ChangeType.Update))
            {
                await HubContext.Clients.All.SendAsync("UPDATE_ACESSOS", e.Entity);
            }
        }
    }
}
