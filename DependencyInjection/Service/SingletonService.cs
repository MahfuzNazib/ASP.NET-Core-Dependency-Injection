using DependencyInjection.IService;

namespace DependencyInjection.Service
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid _operationId;

        public SingletonService()
        {
            _operationId = Guid.NewGuid();
        }

        public Guid GetOparetionID()
        {
            return _operationId;
        }
    }
}
