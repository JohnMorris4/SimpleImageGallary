using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;
using SimpleImageGallery.Models;
using System;
using System.Collections.Generic;

namespace SimpleImageGallery.Controllers
{
    public class ImageGalleryController : Controller
    {
        public IActionResult Index()
        {
            var HikingImageTags = new List<ImageTag>();
            var CityImageTags = new List<ImageTag>();

            var tag1 = new ImageTag()
            {
                Id = 0,
                Description = "Adventure"
            };
            var tag2 = new ImageTag()
            {
                Id = 1,
                Description = "Downtown"
            };
            var tag3 = new ImageTag()
            {
                Id = 2,
                Description = "Mountain Adventure"
            };
            HikingImageTags.Add(tag1);
            CityImageTags.AddRange(new List<ImageTag> { tag2, tag3 });
            var imageList = new List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title= "Hiking Trip",
                    Url = "https://images.pexels.com/photos/547116/pexels-photo-547116.jpeg",
                    Created = DateTime.Now,
                    Tags = HikingImageTags
                },
                new GalleryImage()
                {
                    Title= "City Trip",
                    Url = "https://images.pexels.com/photos/169647/pexels-photo-169647.jpeg",
                    Created = DateTime.Now,
                    Tags = CityImageTags
                },
                new GalleryImage()
                {
                    Title= "Mountain Trip",
                    Url = "https://images.pexels.com/photos/554609/pexels-photo-554609.jpeg",
                    Created = DateTime.Now,
                    Tags = HikingImageTags
                },
                new GalleryImage()
                {
                    Title= "New York",
                    Url = "https://images.pexels.com/photos/374710/pexels-photo-374710.jpeg",
                    Created = DateTime.Now,
                    Tags = CityImageTags
                }
            };
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}