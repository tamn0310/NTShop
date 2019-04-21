﻿using AutoMapper;
using NTShop.Model.Models;
using NTShop.Service;
using NTShop.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NTShop.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductCategoryService _productCategoryService;
        ICommonService _commonService;
        IProductService _productService;

        public HomeController(IProductCategoryService productCategoryService, ICommonService commonService, IProductService productService)
        {
            this._productCategoryService = productCategoryService;
            this._commonService = commonService;
            this._productService = productService;
        }

        public ActionResult Index()
        {
            var slideModel = _commonService.GetSlides();
            var slideView = Mapper.Map<IEnumerable<Slide>,IEnumerable<SlideViewModel>>(slideModel);
            var homeViewModel = new HomeViewModel();
            homeViewModel.Slides = slideView;

            var lastestProductModel = _productService.GetLastest(3);
            var topSaleProductModel = _productService.GetHotProduct(3);
            var lastestProductViewModel = Mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel >> (lastestProductModel);
            var topSaleProductViewModel = Mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel >> (topSaleProductModel);
            homeViewModel.LastestProducts = lastestProductViewModel;
            homeViewModel.TopSaleProducts = topSaleProductViewModel;
            return View(homeViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            var footerModel = _commonService.GetFooter();
            var footerViewModel = Mapper.Map<Footer, FooterViewModel>(footerModel);
            return PartialView(footerViewModel);
        }

        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Category()
        {
            var model = _productCategoryService.GetAll();
            var listProductCategoryViewModel = Mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryViewModel>>(model);
            return PartialView(listProductCategoryViewModel);
        }
    }
}