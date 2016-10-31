using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using monsterapp.dataclient.Models;
using monsterapp.dataclient.NewFolder1;
using MonsterApp.DataAccess;

namespace monsterapp.dataclient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MonsterService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MonsterService.svc or MonsterService.svc.cs at the Solution Explorer and start debugging.
    public class MonsterService : IMonsterService
    {
       private AdoData data = new AdoData();

       public List<GenderDAO> GetGenders()
        {
            var g = new List<GenderDAO>();
            {
                foreach (var gender in data.GetGenders())
                {
                    g.Add(GenderMapper.MapToGenderDAO();
                }
            }
            return g;
        }
    
       public List<TypeDAO> GetMonsterType()
        {
        throw new NotImplementedException();
        }

        List<TitleDAO> IMonsterService.GetTitles()
        {
            throw new NotImplementedException();
        }

        List<TitleDAO> GetTitles()
        {
        throw new NotImplementedException();
        }

    }
}
