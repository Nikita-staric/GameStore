using GameStore.WebUi.HHtmlHel; // Убедитесь, что это правильное пространство имен
using System.Web.Mvc; // Добавьте это пространство именж // Убедитесь, что это пространство имен
namespace GameStore.WebUi.Models
{
    //, мы собираемся передать представлению информацию о количестве доступных страниц,
    //текущей странице и общем количестве товаров в хранилище
    public class PagingInfo
    {
        //Кол-во товаров
        public int TotalItems { get; set; }
        //Кол-во товаров на одной странице 
        public int ItemsPerPage { get; set; }
        //Номер текущей страницы
        public int CurrentPage { get; set; }
        //общее кол-во
        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
            }
        }
    }
}
            

            
