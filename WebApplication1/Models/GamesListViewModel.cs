using GameStoreDomain.Entities;
using GameStore.WebUi.HHtmlHel; // Убедитесь, что это правильное пространство имен
using System.Web.Mvc; // Добавьте это пространство имен


namespace GameStore.WebUi.Models
{
    //  Добавление данных модели представления

    // Цей об'єкт призначений для передачі даних на сторінку 
    public class GamesListViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public PagingInfo  PagingInfo{ get; set; }


    }
}
