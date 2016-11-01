using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monsterapp.dataclient;

namespace MonsterWeb.Logic
{
public class TestData
    {
        private MonsterService data = new MonsterService();
            public void GetGenders()
        {
                    data.GetGenders();
        }

    }
}
