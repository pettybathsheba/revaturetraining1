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
    public class MonsterService : IMonsterService
    {
        private AdoData data = new AdoData();

        public List<GenderDAO> GetGenders()
        {
            var g = new List<GenderDAO>();

            foreach (var gender in data.GetGenders())
            {
                g.Add(GenderMapper.MapToGenderDAO(gender));
            }

            return g;
        }

        public List<TypeDAO> GetMonsterType()
        {
            throw new NotImplementedException();
        }

        public List<TitleDAO> GetTitles()
        {
            throw new NotImplementedException();
        }

    }
}
