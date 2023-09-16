using GameStore.WebUi.Controllers;
using GameStoreDomain.Abstract;
using GameStoreDomain.Entities;
using Moq;
using System.Linq;
using System;
using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using GameStore.WebUi.Models;
using System.Web.Mvc;
using GameStore.WebUi;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Mock<IGameRepository> gg = new Mock<IGameRepository>();
        //    gg.Setup(m => m.Games).Returns(new List<Game>
        //    {
        //        new Game { GameId = 1, Name = "Игра1"},
        //        new Game { GameId = 2, Name = "Игра2"},
        //        new Game { GameId = 3, Name = "Игра3"},
        //        new Game { GameId = 4, Name = "Игра4"},
        //        new Game { GameId = 5, Name = "Игра5"}
        //    });
        //    GameController gameController = new GameController(gg.Object);
        //    gameController.PageSize = 3;


        //    //насколько просто получить данные, возвращаемые методом контроллера. Мы обращаемся к свойству Model объекта результата, чтобы получить последовательность IEnumerable<Game>, сгенерированную методом List(). Затем выполняется проверка, являются ли эти данные ожидаемыми. В этом случае мы преобразовали последовательность в коллекцию с помощью LINQ-метода ToList() и проверили длину и значения отдельных объектов.
        //    // Действие (act)
        //    IEnumerable<Game> resurt = (IEnumerable<Game>)gameController.List(2).Model;
        //    //утверждение
        //    List<Game> games = resurt.ToList();
        //    Assert.IsTrue(games.Count == 2);
        //    Assert.AreEqual(games[0].Name, "Игра4");
        //    Assert.AreEqual(games[1].Name, "Игра5");
        //}

        [TestMethod]

        //Этот тест проверяет вывод вспомогательного метода с использованием литерального строкового значения, содержащего двойные кавычки. 
        public void Can_Generate_Page_Links()
        {
            Mock<IGameRepository> gg = new Mock<IGameRepository>();
               gg.Setup(m => m.Games).Returns(new List<Game>
            {
                new Game { GameId = 1, Name = "Игра1" },
                    new Game { GameId = 2, Name = "Игра2" },
                    new Game { GameId = 3, Name = "Игра3" },
                    new Game { GameId = 4, Name = "Игра4" },
                    new Game { GameId = 5, Name = "Игра5" }
            });


            GameController gameController = new GameController(gg.Object);
             gameController.PageSize = 3;

            //Act
            GamesListViewModel resuurt = (GamesListViewModel)gameController.List(2).Model;

            // Assert
            PagingInfo pageInfo = resuurt.PagingInfo;
            Assert.AreEqual(pageInfo.CurrentPage, 2);
            Assert.AreEqual(pageInfo.ItemsPerPage, 3);
            Assert.AreEqual(pageInfo.TotalItems, 5);
            Assert.AreEqual(pageInfo.TotalPages, 2);







            //// Организация - определение вспомогательного метода HTML - это необходимо
            //// для применения расширяющего метода
            //System.Web.Mvc.HtmlHelper htmlHelper = null;
            //// Организация - создание объекта PagingInfo

            //PagingInfo pagingInfo = new PagingInfo
            //{
            //    CurrentPage = 2,
            //    TotalItems = 28,
            //    ItemsPerPage = 10
            //};
            //// Организация - настройка делегата с помощью лямбда-выражения
            //Func<int,string>pageUrlDelagate=i => "Page" + i;

            //// Действие
            //MvcHtmlString resurt=htmlHelper.PageLinks(pagingInfo, pageUrlDelagate);

            //// Утверждение
            //Assert.AreEqual(@"<a class=""btn btn-default"" href=""Page1"">1</a>"
            //    + @"<a class=""btn btn-default btn-primary selected"" href=""Page2"">2</a>"
            //    + @"<a class=""btn btn-default"" href=""Page3"">3</a>",
            //    resurt.ToString());


        }
    }
    }