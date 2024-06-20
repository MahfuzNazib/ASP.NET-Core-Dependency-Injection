using DependencyInjection.IService;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;

        private readonly IScopedService _scopedService1;
        private readonly IScopedService _scopedService2;

        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;


        public HomeController(ITransientService transientService1, ITransientService transientService2, 
                                IScopedService scopedService1, IScopedService scopedService2,
                                ISingletonService singletonService1, ISingletonService singletonService2)
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {
            ViewBag.Transient1 = _transientService1.GetOperationID();
            ViewBag.Transient2 = _transientService2.GetOperationID();

            ViewBag.ScopedService1 = _scopedService1.GetOperationID();
            ViewBag.ScopedService2 = _scopedService2.GetOperationID();

            ViewBag.SingletonService1 = _singletonService1.GetOparetionID();
            ViewBag.SingletonService2 = _singletonService2.GetOparetionID();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
