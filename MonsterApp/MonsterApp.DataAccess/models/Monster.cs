using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterApp.DataAccess.models
{
   public class Monster
    {
        public int MonsterId { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<int> TitleId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public bool Active { get; set; }

    }
}
