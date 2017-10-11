using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Domain.Services
{
    public class StatusService : ServiceBase<Status>, Interfaces.Services.IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
            : base(statusRepository)
        {
            _statusRepository = statusRepository;
        }
    }
}
