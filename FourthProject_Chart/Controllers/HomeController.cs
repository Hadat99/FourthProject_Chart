using FourthProject_Chart.DataDB;
using FourthProject_Chart.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FourthProject_Chart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly FourthProject_Chart_DBContext _context;

        public HomeController(ILogger<HomeController> logger, FourthProject_Chart_DBContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Test2()
        {
            return View();
        }

        public IActionResult Table_Pdf()
        {
            return View();
        }

        public IActionResult Table_Pdf_2()
        {
            return View();
        }

        public IActionResult Test_JQuery()
        {
            return View();
        }

        public IActionResult Final()
        {
            return View();
        }

        public IActionResult Form(string message)
        {
            var model = new FormModel();
            model.P0007 = _context.P0007PlacingPlanHead.ToList();
            model.P0008 = _context.P0008Compaction.ToList();

            ViewBag.Message = message;
            return View(model);
        }

        [HttpPost]
        public IActionResult Form(P0007_Placing_Plan_Head p7, P0008_Compaction p8)
        {
            using var transaction = _context.Database.BeginTransaction();
            string mess = "";
            try
            {
                var qr1 = (from x in _context.P0007PlacingPlanHead select x).FirstOrDefault();
                var qr2 = (from y in _context.P0008Compaction select y).FirstOrDefault();

                qr1.driving_interval = p7.driving_interval;
                qr1.free_fall_height = p7.free_fall_height;
                qr1.lauch_method = p7.lauch_method;
                qr1.layer_height = p7.layer_height;
                qr1.layer_number = p7.layer_number;
                _context.SaveChanges();

                qr2.insertion_interval = p8.insertion_interval;
                qr2.compaction_work_height = p8.compaction_work_height;
                qr2.compaction_time = p8.compaction_time;
                qr2.re_vibration_follow_up = p8.re_vibration_follow_up;
                qr2.shuttering_vibration = p8.shuttering_vibration;
                _context.SaveChanges();

                transaction.Commit();

                mess = "Thay doi du lieu thanh cong";
            }
            catch (Exception ex)
            {
                mess = "Co loi xay ra: " + ex.Message;
            }

            return RedirectToAction("Form", new {message = mess});
        }


        public IActionResult Form2(string message)
        {
            var model = new FormModel();
            model.P0007 = _context.P0007PlacingPlanHead.ToList();
            model.P0008 = _context.P0008Compaction.ToList();

            ViewBag.Message = message;
            return View(model);
        }

        [HttpPost]
        public IActionResult Form2(P0007_Placing_Plan_Head p7, P0008_Compaction p8)
        {
            using var transaction = _context.Database.BeginTransaction();
            string mess = "";
            try
            {
                var qr1 = (from x in _context.P0007PlacingPlanHead select x).FirstOrDefault();
                var qr2 = (from y in _context.P0008Compaction select y).FirstOrDefault();

                qr1.driving_interval = p7.driving_interval;
                qr1.free_fall_height = p7.free_fall_height;
                qr1.lauch_method = p7.lauch_method;
                qr1.layer_height = p7.layer_height;
                qr1.layer_number = p7.layer_number;
                _context.SaveChanges();

                qr2.insertion_interval = p8.insertion_interval;
                qr2.compaction_work_height = p8.compaction_work_height;
                qr2.compaction_time = p8.compaction_time;
                qr2.re_vibration_follow_up = p8.re_vibration_follow_up;
                qr2.shuttering_vibration = p8.shuttering_vibration;
                _context.SaveChanges();

                transaction.Commit();

                mess = "Thay doi du lieu thanh cong";
            }
            catch (Exception ex)
            {
                mess = "Co loi xay ra: " + ex.Message;
            }

            return RedirectToAction("Form", new { message = mess });
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