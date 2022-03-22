using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShopMVC.Models;
using PieShopMVC.ViewModels;

namespace PieShopMVC.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel viewModel = new PiesListViewModel();
            viewModel.Pies = _pieRepository.AllPies;
            viewModel.CurrentCategory = "Chess Cake";

            return View(viewModel);
        }
    }
}
