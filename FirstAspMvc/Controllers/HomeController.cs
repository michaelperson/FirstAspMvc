using FirstAspMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAspMvc.Controllers
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
            HomeViewModel HVM = new HomeViewModel();

            HVM.Horaire = new HoraireViewModel();
            HVM.Horaire.Week = "Ouvert de 8:00 à 17:00 sans interruptions";
            HVM.Horaire.Weekend = "Ouvert de 12:-10 à 12-09 sur rendez-vous ";
            HVM.MesServices = new List<ServicesModel>();
            HVM.MesServices.Add(new ServicesModel() { Description = "Lorem ipsum dolosit amet, consetetur sadipng elitr sed diam nonumy eirmod.", Image = "page1-img1.png", Titre = "Engine Repair" });
            HVM.MesServices.Add(new ServicesModel() { Description = "Lorem ipsum dolosit amet, consetetur sadipng elitr sed diam nonumy eirmod.", Image = "page1-img2.png", Titre = "Wheel Alignment" });
            HVM.MesServices.Add(new ServicesModel() { Description = "Lorem ipsum dolosit amet, consetetur sadipng elitr sed diam nonumy eirmod.", Image = "page1-img3.png", Titre = "Fluid Exchanges" });
            HVM.AboutUs= @"TechnoGarage is one of free website templates created by TemplateMonster.com team. This website template is optimized for 1280X1024 screen resolution. It is also XHTML & CSS valid.";
            return View(HVM);
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
