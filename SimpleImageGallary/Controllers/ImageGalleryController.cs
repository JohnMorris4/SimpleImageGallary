using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Models;

namespace SimpleImageGallery.Controllers
{
    public class ImageGalleryController : Controller
    {
        public IActionResult Index()
        {
            var model = new GalleryIndexModel()
            {

            };
            return View(model);
        }
    }
}