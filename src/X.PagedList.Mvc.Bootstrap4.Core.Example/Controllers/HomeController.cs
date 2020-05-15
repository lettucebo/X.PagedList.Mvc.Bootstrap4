using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using X.PagedList.Mvc.Bootstrap4.Core.Example.Models;

namespace X.PagedList.Mvc.Bootstrap4.Core.Example.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var datas = SampleData.SampleData.GetData();
            var paged = datas.ToPagedList(page, pageSize);
            return View(paged);
        }

        public ActionResult Minimal(int page = 1, int pageSize = 10)
        {
            var datas = SampleData.SampleData.GetData();
            var paged = datas.ToPagedList(page, pageSize);
            return View(paged);
        }

        public ActionResult PageNumbersOnly(int page = 1, int pageSize = 10)
        {
            var datas = SampleData.SampleData.GetData();
            var paged = datas.ToPagedList(page, pageSize);
            return View(paged);
        }

        public ActionResult Classic(int page = 1, int pageSize = 10)
        {
            var datas = SampleData.SampleData.GetData();
            var paged = datas.ToPagedList(page, pageSize);
            return View(paged);
        }

        public ActionResult Default(int page = 1, int pageSize = 10)
        {
            var datas = SampleData.SampleData.GetData();
            var paged = datas.ToPagedList(page, pageSize);
            return View(paged);
        }
    }
}
