using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace P2P_TicTacToe.Controllers
{
    public class WebRTCController : Controller
    {
        // GET: WebRTCController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WebRTCController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebRTCController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebRTCController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WebRTCController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebRTCController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WebRTCController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebRTCController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
