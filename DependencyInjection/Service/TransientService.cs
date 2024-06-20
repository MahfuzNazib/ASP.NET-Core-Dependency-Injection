using DependencyInjection.IService;

namespace DependencyInjection.Service
{
    public class TransientService : ITransientService
    {
        private readonly Guid _operationId;
        public TransientService()
        {
            _operationId = Guid.NewGuid();
        }
        public Guid GetOperationID() => _operationId;
    }
}
