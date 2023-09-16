using GameStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDomain.Abstract
{
    // позволить вызывающему коду получать последовательность объектов Game, ничего не сообщая о том,
    // как или где хранятся или извлекаются данные.
    public interface IGameRepository
    {
        public IEnumerable<Game> Games { get;  }
    }
}
