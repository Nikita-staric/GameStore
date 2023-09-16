using GameStore.WebUi.Models;
using GameStoreDomain.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WebUi.Controllers
{
    public class GameController : Controller
    {
        public IGameRepository GameRepository { get; set; }
        public int PageSize = 4;
        public GameController(IGameRepository gameRepository)
        {
            GameRepository = gameRepository;
        }
        //Внесенные изменения обеспечивают передачу объекта GamesListViewModel представлению в качестве данных модели.
        public ViewResult List(int page = 1)
        {



            GamesListViewModel model = new GamesListViewModel //передачі даних на сторінку перегляду. Об'єкт включає в себе список ігор та інформацію про сторінку.
            {
                Games = GameRepository.Games.OrderBy(game => game.GameId).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo //інформацію про сторінку, таку як номер поточної сторінки, кількість елементів на сторінці та загальна кількість елементів.
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = GameRepository.Games.Count()
                }
            };
            return View(model);

            //  return View(GameRepository.Games.OrderBy(v=>v.GameId).Skip((page-1)*PageSize).Take(PageSize));
        }

        // GET: GameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
