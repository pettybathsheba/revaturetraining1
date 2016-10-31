using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterApp.DataAccess;
using Xunit;

namespace MonsterApp.Test
{
    public class AdoDataTests
    {
        [Fact]
        public void Test_GetGenders()
        {
            //arrange
            AdoData data = new AdoData();
           // var expected = 11;

            //act
            var actual = data.GetGenders();

            //assert
            Assert.NotNull( actual.Count);
        }
    }
}

