using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Uppgift2.Models;
using System.Text.Json;
using System.IO;

namespace Uppgift2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        public ActionResult Press()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }

        public async Task<IActionResult> Employees()
        {
            Employee[] ouremployees;
            string filename = @"AppData\employees.json";
            using FileStream openStream = System.IO.File.OpenRead(filename);
            ouremployees = await JsonSerializer.DeserializeAsync<Employee[]>(openStream);
            return View(ouremployees);
        }

        public PartialViewResult EnBok()
        {
            var nummer = (string)RouteData.Values["id"];
            int index = int.Parse(nummer);
            var model = BokManager.GetBok(index);
            return PartialView("EnBok", model);
        }

        public async Task<IActionResult> SendFormAsync()
        {
            var fornamn = Request.Form["firstname"];
            var eftnamn = Request.Form["lastname"];
            var epost = Request.Form["epost"];
            var land = Request.Form["country"];
            var mess = Request.Form["subject"];

            if (string.IsNullOrEmpty(fornamn) || string.IsNullOrWhiteSpace(fornamn))
                return View("Kontakt");
            if (string.IsNullOrEmpty(eftnamn) || string.IsNullOrWhiteSpace(eftnamn))
                return View("Kontakt");
            if (string.IsNullOrEmpty(epost) || string.IsNullOrWhiteSpace(epost))
                return View("Kontakt");
            if (string.IsNullOrEmpty(mess) || string.IsNullOrWhiteSpace(mess))
                return View("Kontakt");

            KontaktForm nykontakt = new KontaktForm();
            ViewBag.Name = fornamn + " " + eftnamn;
            ViewBag.EPost = epost;
            ViewBag.Land = land;
            ViewBag.Message = mess;
            nykontakt.ForNamn = fornamn;
            nykontakt.EftNamn = eftnamn;
            nykontakt.EPost = epost;
            nykontakt.Land = land;
            nykontakt.Meddelande = mess;
            ViewBag.ID_Num = nykontakt.ID_NUM;
            ViewBag.Datum = nykontakt.AnkomstDatum;
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Name, ViewBag.Name));
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.
            AuthenticationScheme, principal, new AuthenticationProperties() { IsPersistent = false });
            return View("Svar");
        }
    }
}
