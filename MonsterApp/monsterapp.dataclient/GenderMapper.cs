using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using monsterapp.dataclient.Models;
using MonsterApp.DataAccess;

namespace monsterapp.dataclient
{
    public class GenderMapper
    {

        public static GenderDAO MapToGenderDAO(Gender gender)
        {
            var g = new GenderDAO();

            g.id = gender.GenderId;
            g.name = gender.GenderName;

        }


        public static Gender MapToGender(GenderDAO gender)
        {
            throw new NotImplementedException();
        }

        public static object MapTo(object o)
        {
            var properties = o.GetType().GetProperties();
            var ob = new object();
            foreach (var item in properties.ToList())
            {
                ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));

            }
            return ob;

        }

    }
}