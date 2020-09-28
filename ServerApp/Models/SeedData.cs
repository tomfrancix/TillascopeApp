﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ServerApp.Models;

namespace ServerApp.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0)
            {
                var Bernard = new Blueprint { Title = "Bernard", Summary = "Our simplest and most affordable design range, these little stages are a perfect match for the office desk, console table, kitchen counter, hell, you name it, it works! Built for a single Tillandsia and available in range of different sizes, youd be surprised how big the air plants these stages can show off can be!", ImageIcon = "Bernard.jpg" };
                var Nicholas = new Blueprint { Title = "Nickolas", Summary = "A seasonal wall mounted stage, named [after] the good old Saint Nick, and designed [to] show [off] multiple small Tillandsia simultaneously. The overlapping branches are perfect for slotting in air plants with the way their unique leaf structures grip on without the need for any adhesive.", ImageIcon = "Nicholas.jpg" };
                var Arthur = new Blueprint { Title = "Arthur", Summary = "A simplistic, geometric design with some beautifully innovative features. Arthur stages are the perfect way to highlight a gorgeous sherical glass terrarium containing a beautiful landscape on which to display your Tillandsia. Supported by two mounts on either side to help prevent the stage from toppling over, you can rest assured that it will take quite some force to capsise it!", ImageIcon = "Arthur.jpg" };
                var Dolores = new Blueprint { Title = "Dolores", Summary = "A quirkly little (or large!) stage resembling a tumbleweed. The perfect accompainment to your workspace, kitchen, lounge, bathroom… you name it! To really get that blowing in the wind vibe we find pairing Dolores with Tillandsia paleacea or albertiana really gets the ball rolling ", ImageIcon = "Dolores.jpg" };
                var Gia = new Blueprint { Title = "Gia", Summary = "A unique twist on an otherwise commonplace idea, although we do truly love geometric designs! Gia is the first ever Tillascope wall mounted design, and crafted to resemble a lightning bolt, these stages harness the power to stun the observer by sheer fierceness!", ImageIcon = "Gia.jpg" };
                var Julia = new Blueprint { Title = "Julia", Summary = "We love geometry - and our Julia range is a perfect example of how the simplistic structure of geometric shapes works so well as a means to shine the spotlight on your Tillandsia. You can hang it just about anywhere!", ImageIcon = "Julia.jpg" };
                var Kala = new Blueprint { Title = "Kala", Summary = "As much as we love simplicity, we also love an extravaganza! Which is exactly what Kala brings to the table. Designed to be a glass treehouse, Kala is instantly noticeable for its eccentric appearance. True centrepiece perfection.", ImageIcon = "Kala.jpg" };
                var Lindsay = new Blueprint { Title = "Lindsay", Summary = "This simple, yet remarkably cool design is our Lindsay range, made to fit larger Tillandsia and designed with the suspension fitted directly around the ring allowing for the stage to hang flawlessly upright.", ImageIcon = "Lindsay.jpg" };
                var Liza = new Blueprint { Title = "Liza", Summary = "Beauty in simplicity perfectly sums up the Liza range. Available in a multitude of sizes and finishes, this stage seamlessly fits in to any environment.", ImageIcon = "Liza.jpg" };
                var Maria = new Blueprint { Title = "Maria", Summary = "Maria is a lovely little hanging stage built with a central ring-shaped mount fastened between two equally sized larger rings. In addition to being one of our most affordable designs, it is also one of our most versatile. With the variety of diferent materials they can be built from there is a Maria to suit everyone!", ImageIcon = "Maria.jpg" };
                var Sun = new Blueprint { Title = "Sun ", Summary = "Sun stages are an affordable hanging design made from a single strand of metal that curls round into a spring-like mount for your Tillandsia. Available in numerous finishes, theres a sun to appeal to anyone.", ImageIcon = "Sun.jpg" };
                var Roy = new Blueprint { Title = "Roy", Summary = "A generic grid shaped stage designed for the Tillandsia collectors out there! Roy stages have the capacity to show off as many plants as possible, and are available is numerous shapes and sizes to suit anyones needs!", ImageIcon = "Roy.jpg" };
                var Albert = new Blueprint { Title = "Albert", Summary = "Albert stages are a modern, simplistic and eye catching way to display endless combinations of Tillandsia, be it a single air plant to steal the spotlight or basically as many as you can fit in there! Being a wall mounted stage, Albert takes up to no space at all, whilst its impact on]your home remains unprecedented.", ImageIcon = "albertx.jpg" };
                var Antonio = new Blueprint { Title = "Antonio", Summary = "With practicality in mind, the antonio design range brings to the table, well, exactly that! Not only is it a great way to mount your air plant, it also has a characteristic hook at the top from which you can hang your air plant to dry, allowing it to drain properly following watering and eliminating the need to remember to move it back from drying rack to its stage. And to top it all off it just so happens to be one of the most affordable design ranges we have to offer.", ImageIcon = "antoniox.jpg" };
                var Caelum = new Blueprint { Title = "Caelum", Summary = "A beautiful, [simple] design that looks good hanging [from] just about anywhere. Available in a variety of sizes and finishes to choose from.", ImageIcon = "caelumx.jpg" };
                var Hayden = new Blueprint { Title = "Hayden", Summary = "A wall mounted design inspired [by] the winter skeletons of the forest. Hayden stages are all built from strands of aluminium that have been woven together by hand into a rope-like structure and crafted into an eye-catching way to display your Tillandsia.", ImageIcon = "haydenx.jpg" };
                var Isaac = new Blueprint { Title = "Isaac", Summary = "Isaac stages draw their [character from] some of the most recognisably quintessential structures in nature, and are named after the Earth adept protagonist from the Nintendo series Golden Sun. A simple, but beautiful way of showing off multiple Tillandsia at once, Isaac stages make a great centrepiece!", ImageIcon = "isaacx.jpg" };
                var Ivan = new Blueprint { Title = "Ivan", Summary = "Ivan stages are a prime example of the beauty in simplicity. A metal ribbon-like structure mounted onto a wooden base is all you need to draw the eye in on your Tillandsia. With two mounts this design is built to hold any two air plants that compliment each other perfectly.", ImageIcon = "ivanx.jpg" };
                var Jonathan = new Blueprint { Title = "Jonathan", Summary = "Baring a striking resemblance to the Iron throne, Jonathan stages are appropriately named after the rightful king of Westeros Jon Snow from the HBO series Game of Thrones / novel series A Song of Ice and Fire by George R.R. Martin. This stage is designed to show off multiple Tillandsia at once, though it looks just as good with just one too!", ImageIcon = "jonathanx.jpg" };
                var Leonardo = new Blueprint { Title = "Leonardo", Summary = "…Da Vinci? Di Caprio? How about… De Tillandsia! This stunning surface mounted design is one of our most affordable stages, guaranteed to bring hoops of joy to the table.", ImageIcon = "leonardox.jpg" };
                var Mikaela = new Blueprint { Title = "Mikaela", Summary = "The Mikaela design range is a dual levelled stage comprised of two metal rings with a steel wire mesh that holds tightly together via the grooves sawed into the structure around them These are fixed into a central aluminium pole and mounted into specialist hardware that is gripped in the centre of two steel rings with  wire and fixed together with a small strip of brass, adding a subtle hint of colour into the design.", ImageIcon = "mikaelax.jpg" };
                var Victoria = new Blueprint { Title = "Victoria", Summary = "A unique, classy, almost regal design made from a central branch to slot your Tillandsia in between. Designed with the more tentacle-like varieties of air plant in mind, though still capable of houing a whole lot more.", ImageIcon = "victoriax.jpg" };
                var Wolfgang = new Blueprint { Title = "Wolfgang", Summary = "Wolfgang is a surface mounted stage made from a central pole fixed onto a round base, and with a spring-like mount for your Tillandsia surrounded by an inverted dome of flat metal strips. An eye-catcher by every sense of the word!", ImageIcon = "wolfgangx.jpg" };
                var Elliot = new Blueprint { Title = "Elliot", Summary = "The original design that started it all and Tillascope was born, named in honour of our very first customer. Elliott stages are one of our most versatile designs, since they can be crafted from a variety of different materials and come in all sorts of sizes. Minimalistic, but never lacking in character, these stages never fail to draw the eye in for a closer look!", ImageIcon = "Elliott.jpg" };

                context.Products.AddRange(
                    new Product { Category = "Stage", Subcategory = "Albert", Blueprint = Albert, Quantity = 1, Description = "", Price = 85, ImageIcon = "albert1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Albert", Blueprint = Albert, Quantity = 1, Description = "", Price = 75, ImageIcon = "albert2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Antonio", Blueprint = Antonio, Quantity = 1, Description = "", Price = 45, ImageIcon = "antonio1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Antonio", Blueprint = Antonio, Quantity = 1, Description = "", Price = 45, ImageIcon = "antonio2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Arthur", Blueprint = Arthur, Quantity = 1, Description = "", Price = 45, ImageIcon = "arthur1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Bernard", Blueprint = Bernard, Quantity = 1, Description = "", Price = 45, ImageIcon = "bernard1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Bernard", Blueprint = Bernard, Quantity = 1, Description = "", Price = 45, ImageIcon = "bernard2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Bernard", Blueprint = Bernard, Quantity = 1, Description = "", Price = 45, ImageIcon = "bernard2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Bernard", Blueprint = Bernard, Quantity = 1, Description = "", Price = 45, ImageIcon = "bernard4.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Bernard", Blueprint = Bernard, Quantity = 1, Description = "", Price = 45, ImageIcon = "bernard7.1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Bernard", Blueprint = Bernard, Quantity = 1, Description = "", Price = 45, ImageIcon = "bernard6.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Caelum", Blueprint = Caelum, Quantity = 1, Description = "", Price = 45, ImageIcon = "caelum1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Caelum", Blueprint = Caelum, Quantity = 1, Description = "", Price = 45, ImageIcon = "caelum2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Dolores", Blueprint = Dolores, Quantity = 1, Description = "", Price = 45, ImageIcon = "dolores1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Dolores", Blueprint = Dolores, Quantity = 1, Description = "", Price = 45, ImageIcon = "dolores1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Elliot", Blueprint = Elliot, Quantity = 1, Description = "", Price = 45, ImageIcon = "elliott1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Gia", Blueprint = Gia, Quantity = 1, Description = "", Price = 45, ImageIcon = "gia1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Gia", Blueprint = Gia, Quantity = 1, Description = "", Price = 45, ImageIcon = "gia2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Gia", Blueprint = Gia, Quantity = 1, Description = "", Price = 45, ImageIcon = "gia2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Hayden", Blueprint = Hayden, Quantity = 1, Description = "", Price = 45, ImageIcon = "hayden1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Hayden", Blueprint = Hayden, Quantity = 1, Description = "", Price = 45, ImageIcon = "hayden2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Hayden", Blueprint = Hayden, Quantity = 1, Description = "", Price = 45, ImageIcon = "hayden3.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Isaac", Blueprint = Isaac, Quantity = 1, Description = "", Price = 45, ImageIcon = "isaac1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Ivan", Blueprint = Ivan, Quantity = 1, Description = "", Price = 45, ImageIcon = "ivan1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Ivan", Blueprint = Ivan, Quantity = 1, Description = "", Price = 45, ImageIcon = "ivan2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Jonathan", Blueprint = Jonathan, Quantity = 1, Description = "", Price = 45, ImageIcon = "jonathan1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Julia", Blueprint = Julia, Quantity = 1, Description = "", Price = 45, ImageIcon = "julia1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Kala", Blueprint = Kala, Quantity = 1, Description = "", Price = 45, ImageIcon = "kala1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Leonardo", Blueprint = Leonardo, Quantity = 1, Description = "", Price = 45, ImageIcon = "leonardo1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Leonardo", Blueprint = Leonardo, Quantity = 1, Description = "", Price = 45, ImageIcon = "leonardo2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Leonardo", Blueprint = Leonardo, Quantity = 1, Description = "", Price = 45, ImageIcon = "leonardo3.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Leonardo", Blueprint = Leonardo, Quantity = 1, Description = "", Price = 45, ImageIcon = "leonardo4.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Leonardo", Blueprint = Leonardo, Quantity = 1, Description = "", Price = 45, ImageIcon = "leonardo5.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Lindsay", Blueprint = Lindsay, Quantity = 1, Description = "", Price = 45, ImageIcon = "lindsay1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Lindsay", Blueprint = Lindsay, Quantity = 1, Description = "", Price = 45, ImageIcon = "lindsay2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Lindsay", Blueprint = Lindsay, Quantity = 1, Description = "", Price = 45, ImageIcon = "lindsay1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Liza", Blueprint = Liza, Quantity = 1, Description = "", Price = 45, ImageIcon = "liza1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Maria", Blueprint = Maria, Quantity = 1, Description = "", Price = 45, ImageIcon = "maria1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Maria", Blueprint = Maria, Quantity = 1, Description = "", Price = 45, ImageIcon = "maria2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Maria", Blueprint = Maria, Quantity = 1, Description = "", Price = 45, ImageIcon = "maria3.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Maria", Blueprint = Maria, Quantity = 1, Description = "", Price = 45, ImageIcon = "maria4.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Maria", Blueprint = Maria, Quantity = 1, Description = "", Price = 45, ImageIcon = "maria5.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Maria", Blueprint = Maria, Quantity = 1, Description = "", Price = 45, ImageIcon = "maria6.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Mikaela", Blueprint = Mikaela, Quantity = 1, Description = "", Price = 45, ImageIcon = "mikaela1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Nicholas", Blueprint = Nicholas, Quantity = 1, Description = "", Price = 45, ImageIcon = "nicholas1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Nicholas", Blueprint = Nicholas, Quantity = 1, Description = "", Price = 45, ImageIcon = "nicholas2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Roy", Blueprint = Roy, Quantity = 1, Description = "", Price = 45, ImageIcon = "roy1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Sun", Blueprint = Sun, Quantity = 1, Description = "", Price = 45, ImageIcon = "sun1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Sun", Blueprint = Sun, Quantity = 1, Description = "", Price = 45, ImageIcon = "sun2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Sun", Blueprint = Sun, Quantity = 1, Description = "", Price = 45, ImageIcon = "sun3.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Victoria", Blueprint = Victoria, Quantity = 1, Description = "", Price = 45, ImageIcon = "victoria1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Wolfgang", Blueprint = Wolfgang, Quantity = 1, Description = "", Price = 45, ImageIcon = "wolfgang1.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Wolfgang", Blueprint = Wolfgang, Quantity = 1, Description = "", Price = 45, ImageIcon = "wolfgang2.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Wolfgang", Blueprint = Wolfgang, Quantity = 1, Description = "", Price = 45, ImageIcon = "wolfgang3.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } },
                    new Product { Category = "Stage", Subcategory = "Wolfgang", Blueprint = Wolfgang, Quantity = 1, Description = "", Price = 45, ImageIcon = "wolfgang4.jpg", Images = new List<Image> { new Image { ImageIcon = "Maria1.JPG" }, new Image { ImageIcon = "Maria1.JPG" } }, Ratings = new List<Rating> { new Rating { Stars = 4 }, new Rating { Stars = 2 } } }
                 

                    );
                context.SaveChanges();
            
            }
        }
    }
}