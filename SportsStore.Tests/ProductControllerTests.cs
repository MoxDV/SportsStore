using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;

namespace SportsStore.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate() {
            // Организация
            var _mock = new Mock<IProductRepository>();
            _mock.Setup(m => m.Products).Returns(new[] {
                new Product{ ProductID = 1, Name = "P1"},
                new Product{ ProductID = 2, Name = "P2"},
                new Product{ ProductID = 3, Name = "P3"},
                new Product{ ProductID = 4, Name = "P4"},
                new Product{ ProductID = 5, Name = "P5"},
            });
            var _controller = new ProductController(_mock.Object);
            _controller.PageSize = 3;
            // Действие
            var _result = _controller.List(2).ViewData.Model as IEnumerable<Product>;
            // Утверждение
            var _prodArray = _result.ToArray();
            Assert.True(_prodArray.Length == 2);
            Assert.Equal("P4", _prodArray[0].Name);
            Assert.Equal("P5", _prodArray[1].Name);
        }
    }
}
