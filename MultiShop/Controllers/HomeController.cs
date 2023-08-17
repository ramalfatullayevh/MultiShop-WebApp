using Microsoft.AspNetCore.Mvc;
using MultiShop.Models;

namespace MultiShop.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Shirt", Price = 100.99f, DiscountPrice = 89.99f, Image = "product-2.jpg" });
            products.Add(new Product { Id = 2, Name = "Apple Watch", Price = 199.99f, DiscountPrice = 89.99f, Image = "product-6.jpg" });
            products.Add(new Product { Id = 3, Name = "Drone", Price = 499.99f, DiscountPrice = 429.99f, Image = "product-5.jpg" });
            products.Add(new Product { Id = 4, Name = "Camera", Price = 200.99f, DiscountPrice = 189.99f, Image = "product-1.jpg" });
            products.Add(new Product { Id = 1, Name = "Lamb", Price = 59.99f, DiscountPrice = 49.99f, Image = "product-3.jpg" });

            ViewBag.Categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Women Clothes",
                    Image = "cat-1.jpg",
                    Products=products,

                },

                new Category
                {
                    Id = 2,
                    Name = "Cosmestics",
                    Image = "cat-4.jpg",
                    Products=products,



                },

                new Category
                {
                    Id = 1,
                    Name = "Shoes",
                    Image = "cat-3.jpg",
                    Products=products,


                }

            };

            ViewBag.Slides = new List<Slide>()
            {
                new Slide
                {
                    Id = 1,
                    Name = "Kisi paltari",
                    Image = "carousel-1.jpg",
                    Description = "Kishi paltarlari movcuddur"

                },

                new Slide
                {
                    Id = 2,
                    Name = "Qadin Paltarlari",
                    Image = "carousel-2.jpg",
                    Description = "Qadin paltarlari movcuddur"


                },

                new Slide
                {
                    Id = 3,
                    Name = "Usaq Paltarlari",
                    Image = "carousel-3.jpg",
                    Description = "Usaq paltarlari movcuddur"


                }

            };

            ViewBag.Offers = new List<Offer>()
            {
                new Offer
                {
                    Id = 1,
                    PricePercent = 34,
                    Image = "offer-1.jpg"


                },

                new Offer
                {
                    Id = 2,
                    PricePercent = 77,
                    Image = "offer-2.jpg"
                },

                new Offer
                {
                    Id = 3,
                    PricePercent = 99,
                    Image = "offer-1.jpg"
                },
            };
            return View(products);
        }

        public IActionResult Shop()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Shirt", Price = 100.99f, DiscountPrice = 89.99f, Image = "product-2.jpg" });
            products.Add(new Product { Id = 2, Name = "Apple Watch", Price = 199.99f, DiscountPrice = 89.99f, Image = "product-6.jpg" });
            products.Add(new Product { Id = 3, Name = "Drone", Price = 499.99f, DiscountPrice = 429.99f, Image = "product-5.jpg" });
            products.Add(new Product { Id = 4, Name = "Camera", Price = 200.99f, DiscountPrice = 189.99f, Image = "product-1.jpg" });
            products.Add(new Product { Id = 1, Name = "Lamb", Price = 59.99f, DiscountPrice = 49.99f, Image = "product-3.jpg" });
            return View(products);
        }

        public IActionResult Detail()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Shirt", Price = 100.99f, DiscountPrice = 89.99f, Image = "product-2.jpg" });
            products.Add(new Product { Id = 2, Name = "Apple Watch", Price = 199.99f, DiscountPrice = 89.99f, Image = "product-6.jpg" });
            products.Add(new Product { Id = 3, Name = "Drone", Price = 499.99f, DiscountPrice = 429.99f, Image = "product-5.jpg" });
            products.Add(new Product { Id = 4, Name = "Camera", Price = 200.99f, DiscountPrice = 189.99f, Image = "product-1.jpg" });
            products.Add(new Product { Id = 1, Name = "Lamb", Price = 59.99f, DiscountPrice = 49.99f, Image = "product-3.jpg" });
            return View(products);  
        }
    }
}
