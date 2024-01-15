using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.EventArgs;
using Shared_Class_Vivo_Apps.Data;
using Vivo_Apps_API.Hubs;
using Shared_Class_Vivo_Apps.DB_Context_Vivo_MAIS;

namespace Vivo_Apps_API
{
    public class TableDependencyService
    {
        Vivo_MaisContext _context = new();
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
