using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Domain.Services
{
    public class InTaskService : ServiceBase<InTask>, Interfaces.Services.IInTaskService
    {
        private readonly IInTaskRepository _inTaskRepository;

        public InTaskService(IInTaskRepository inTaskRepository)
            : base(inTaskRepository)
        {
            _inTaskRepository = inTaskRepository;
        }
    }
}
