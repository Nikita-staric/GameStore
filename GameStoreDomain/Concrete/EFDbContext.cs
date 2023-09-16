using GameStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDomain.Concrete
{
    //Создание хранилища для объектов Game

    //Создание контекста Entity Framework
    internal class EFDbContext:DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
