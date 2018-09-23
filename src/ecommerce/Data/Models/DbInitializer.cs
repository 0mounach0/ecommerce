using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerce.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "OnePlus 5T",
                        Price = 5000M,
                        ShortDescription = "OnePlus 5T is an Android smartphone made by OnePlus",
                        LongDescription = "The OnePlus 5T is an Android smartphone made by OnePlus. It was unveiled on 16 November 2017[5] via a live streamed press event which aired on YouTube,[6]. It went on sale on 21 November 2017.[7][8] It is an incremental update to its predecessor, the OnePlus 5 which was unveiled only five months prior. Some notable changes that occurred were the larger display and thinner bezels found on the device and the repositioning of the fingerprint scanner. On 17 May 2018 the OnePlus 5T was succeeded by the OnePlus 6.",
                        Category = Categories["Phone"],
                        ImageUrl = "/Images/Img/OnePlus_5T.png",
                        InStock = true,
                        isPreferredProduct = true,
                        ImageThumbnailUrl = "/Images/Img/OnePlus_5T.png"
                    },
                    new Product
                    {
                        Name = "iPhone X",
                        Price = 14690M,
                        ShortDescription = "iPhone X is Apple's new flagship 10th anniversary iPhone.",
                        LongDescription = "iPhone X (X pronounced ten /tɛn/)[9] is a smartphone designed, developed, and marketed by Apple Inc. It was announced on September 12, 2017, alongside the iPhone 8 and iPhone 8 Plus at the Steve Jobs Theater in the Apple Park campus. The phone was released on November 3, 2017. This device marks the iPhone series' tenth anniversary, with X being the symbol for ten in Roman numerals.",
                        Category = Categories["Phone"],
                        ImageUrl = "/Images/Img/iPhone_X.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/iPhone_X.jpg"
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy S9",
                        Price = 7200M,
                        ShortDescription = "Samsung Galaxy S9 Android smartphone.",
                        LongDescription = "The Samsung Galaxy S9 and Samsung Galaxy S9+ (shortened to S9 and S9+, respectively) are Android smartphones produced by Samsung Electronics as part of the Samsung Galaxy S series. The devices were revealed at the Mobile World Congress in Barcelona on 25 February 2018, as the successors to the Samsung Galaxy S8 and S8+.",
                        Category = Categories["Phone"],
                        ImageUrl = "/Images/Img/Samsung_Galaxy_S9.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/Samsung_Galaxy_S9.jpg"
                    },
                    new Product
                    {
                        Name = "iPad Pro",
                        Price = 8490M,
                        ShortDescription = "tablet computers designed, developed and marketed by Apple Inc.",
                        LongDescription = "is a line of tablet computers designed, developed and marketed by Apple Inc., which run the iOS mobile operating system. The first iPad was released on April 3, 2010; the most recent iPad models are the iPad (2018), released on March 27, 2018, the 10.5-inch (270 mm) and 12.9-inch (330 mm) 2G iPad Pro released on June 13, 2017. The user interface is built around the device's multi-touch screen, including a virtual keyboard. All iPads can connect via Wi-Fi; some models also have cellular connectivity.",
                        Category = Categories["Tablet"],
                        ImageUrl = "/Images/Img/ipad_pro-600x300.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/ipad_pro-600x300.jpg"
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy Tab 3",
                        Price = 2500M,
                        ShortDescription = "The Samsung Galaxy Tab 3 is a 7-inch Android-based tablet.",
                        LongDescription = "The Samsung Galaxy Tab 3 7.0 is a 7-inch Android-based tablet computer produced and marketed by Samsung Electronics.[5] It belongs to the third generation of the Samsung Galaxy Tab series, which also includes the 8-inch Galaxy Tab 3 8.0 and the 10.1-inch Galaxy Tab 3 10.1. It was announced on 29 April 2013 and launched in the US on 7 July 2013.",
                        Category = Categories["Tablet"],
                        ImageUrl = "/Images/Img/Samsung_Galaxy_Tab_3.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/Samsung_Galaxy_Tab_3.jpg"
                    },
                    new Product
                    {
                        Name = "huawei mediapad m3",
                        Price = 3630M,
                        ShortDescription = "Huawei MediaPad M3 8.4 Android tablet.",
                        LongDescription = "Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016 Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016 Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016 Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016 Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016 Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016 Huawei MediaPad M3 8.4 Android tablet. Announced Sep 2016.",
                        Category = Categories["Tablet"],
                        ImageUrl = "/Images/Img/huawei_mediapad_m3.jpg",
                        InStock = true,
                        isPreferredProduct = true,
                        ImageThumbnailUrl = "/Images/Img/huawei_mediapad_m3.jpg"
                    },
                    new Product
                    {
                        Name = "LG OLED65W7P",
                        Price = 77000M,
                        ShortDescription = "An organic light-emitting diode .",
                        LongDescription = "An organic light-emitting diode (OLED) is a light-emitting diode (LED) in which the emissive electroluminescent layer is a film of organic compound that emits light in response to an electric current. This layer of organic semiconductor is situated between two electrodes; typically, at least one of these electrodes is transparent. OLEDs are used to create digital displays in devices such as television screens, computer monitors, portable systems such as mobile phones, handheld game consoles and PDAs. A major area of research is the development of white OLED devices for use in solid-state lighting applications.",
                        Category = Categories["Television"],
                        ImageUrl = "/Images/Img/LG_OLED65W7P.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/LG_OLED65W7P.jpg"
                    },
                    new Product
                    {
                        Name = "Samsung Q9FN",
                        Price = 36000M,
                        ShortDescription = "Samsung’s 2018 Q9FN QLED is the best Samsung TV ever made.",
                        LongDescription = "Samsung’s 2018 Q9FN QLED TV is the epiphany we’ve been waiting for. Simply put, it’s the best TV Samsung has ever made, and the most well-rounded LCD I’ve tested. Most shockingly, it’s not even just about the killer picture.",
                        Category = Categories["Television"],
                        ImageUrl = "/Images/Img/Samsung_Q9FN.jpg",
                        InStock = true,
                        isPreferredProduct = true,
                        ImageThumbnailUrl = "/Images/Img/Samsung_Q9FN.jpg"
                    },
                    new Product
                    {
                        Name = "SONY A1E",
                        Price = 31000M,
                        ShortDescription = "A1E | OLED | 4K Ultra HD | High Dynamic Range (HDR) | Smart TV",
                        LongDescription = "Our design concept The artist aesthetics of the One Slate experience has won three top awards. Its ultra-minimalist styling with all elements integrated into a single slate for a clear, cable-free look impressed judges. The concept was praised for blending harmoniously into environments and for providing a unique visual and aural experience with sound directly from the screen. ",
                        Category = Categories["Television"],
                        ImageUrl = "/Images/Img/SONY_A1E.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/SONY_A1E.jpg"
                    },
                    new Product
                    {
                        Name = "Dell XPS 15",
                        Price = 25600M,
                        ShortDescription = "Dell XPS (Xtreme Performance System) .",
                        LongDescription = "The Dell XPS 8700 is Dell's second most recent product in the XPS line. It is designed for moderate to heavy gaming and high-end workstation performance. It features a Dell 0KWVT8 motherboard with a LGA-1150 socket. It comes with a quad-core Intel Core i7 processor and an Nvidia Geforce GTX 660. A special edition is available with an AMD Radeon R9 270.",    
                        Category = Categories["Pc"],
                        ImageUrl = "/Images/Img/Dell_XPS_15.jpg",
                        InStock = true,
                        isPreferredProduct = true,
                        ImageThumbnailUrl = "/Images/Img/Dell_XPS_15.jpg"
                    },
                    new Product
                    {
                        Name = "MacBook Pro 13",
                        Price = 320005M,
                        ShortDescription = "The MacBook Pro (sometimes abbreviated as MBP).",
                        LongDescription = "The MacBook is a brand of notebook computers manufactured by Apple Inc. from May 2006 to February 2012, and relaunched in 2015. It replaced the iBook series and 12-inch PowerBook series of notebooks as a part of the Apple-Intel transition from PowerPC. Positioned as the low end of the MacBook family, below the premium ultra-portable MacBook Air and the powerful MacBook Pro,[1] the MacBook was aimed at the consumer and education markets.[2] It was the best-selling Macintosh ever. For five months in 2008, it was the best-selling laptop of any brand in US retail stores.[3] Collectively, the MacBook brand is the world's top-selling line of premium laptops.",
                        Category = Categories["Pc"],
                        ImageUrl = "/Images/Img/MacBook_Pro_13.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/MacBook_Pro_13.jpg"
                    },
                    new Product
                    {
                        Name = "LG Gram 15",
                        Price = 23600M,
                        ShortDescription = "LG laptops were all under the Gram branding.",
                        LongDescription = "Starting in 2015, LG laptops were all under the Gram branding. The LG Gram is a lineup of laptop computers weighing around 1 kg manufactured by LG electronics.[5][6]The Gram was announced in September 2015 with two screen sizes available: 13.3and 14.[7] The 15.6 model was introduced during CES 2016.[8][9][10][11] During CES 2017, the 2017 edition of the Gram was introduced.[12][13] During CES 2018, the 2018 edition of the Gram was introduced.",
                        Category = Categories["Pc"],
                        ImageUrl = "/Images/Img/LG_Gram_15.jpg",
                        InStock = true,
                        isPreferredProduct = false,
                        ImageThumbnailUrl = "/Images/Img/LG_Gram_15.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Phone", Description="Phone" },
                        new Category { CategoryName = "Tablet", Description="Tablet" },
                        new Category { CategoryName = "Pc", Description="Pc" },
                        new Category { CategoryName = "Television", Description="Television" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
