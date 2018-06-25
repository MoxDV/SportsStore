using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(ApplicationDbContext context) {
            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product { Name = "Каяк",
                        Description = "Лодка для одного человека",
                        Category  = "Водный спорт", Price = 275 },
                    new Product {
                        Name = "Спасательный жилет",
                        Description = "Защитные и модные",
                        Category = "Водный спорт", Price = 48.95m
                    },
                    new Product {
                        Name = "Футбольный мяч",
                        Description = "Утвержденный FIFA размер и вес",
                        Category = "Футбол", Price = 19.50m
                    },
                    new Product {
                        Name = "Угловые флаги",
                        Description = "Создайте свою игровую площадку с профессиональным оформлением",
                        Category = "Футбол", Price = 34.95m
                    },
                    new Product {
                        Name = "Стадион",
                        Description = "Упакованный плоскостью 35,000-местный стадион",
                        Category = "Футбол", Price = 79500
                    },
                    new Product {
                        Name = "Кепка размышления",
                        Description = "Повышает мозговую эффективность на 75%",
                        Category = "Шахматы", Price = 16
                    },
                    new Product {
                        Name = "Передвижное кресло",
                        Description = "Тайно создайте преимущество перед Вашим противников ",
                        Category = "Шахматы", Price = 29.95m
                    },
                    new Product {
                        Name = "Настольная шахматная доска",
                        Description = "Интересная игра для семьи",
                        Category = "Шахматы", Price = 75
                    },
                    new Product {
                        Name = "Шикарный король",
                        Description = "Позолоченный, инкрустированный алмазом Король",
                        Category = "Шахматы", Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
