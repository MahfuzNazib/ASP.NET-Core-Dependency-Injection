using DependencyInjection.IService;

namespace DependencyInjection.Service
{
    public class ScopedService : IScopedService
    {
        private readonly Guid _oparetionId;

        public ScopedService() 
        { 
            _oparetionId = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            return _oparetionId;
        }
    }
}
