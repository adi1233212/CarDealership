using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FavoritesList : List<Favorites>
    {

        public FavoritesList() { }

        public FavoritesList(IEnumerable<Favorites> list) : base(list) { }

        public FavoritesList(IEnumerable<BaseEntity> list) : base(list.Cast<Favorites>().ToList()) { }

    }
}
