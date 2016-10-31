using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterAppWorking.Data;
using Xunit;

namespace MonsterWorkingTest
{
    public class AdoDataTest
    {
           [Fact]
        public void Test_GetGenders()
        {
            var data = new AdoData();
            var actual = data.GetGenders();

            Assert.NotNull(actual);
        }
    }

}

