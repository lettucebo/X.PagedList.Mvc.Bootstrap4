using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace X.PagedList.Mvc.Bootstrap4.Example.Controllers
{
    public class HomeController : Controller
    {
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