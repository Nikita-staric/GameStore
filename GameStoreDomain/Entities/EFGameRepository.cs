using GameStoreDomain.Abstract;
using GameStoreDomain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDomain.Entities
{
    //Создание хранилища для объектов Game   


    //Класс EFGameRepository представляет необходимое хранилище.
    //Он реализует интерфейс IGameRepository и использует экземпляр
    //EFDbContext для извлечения данных из базы посредством Entity Framework. 
    public class EFGameRepository : IGameRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Game> Games { get { return context.Games; } }
    }
}
