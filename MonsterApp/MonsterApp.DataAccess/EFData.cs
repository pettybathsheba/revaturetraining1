using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MonsterApp.DataAccess
{
   public class EFData
    {
        private MonsterDBEntities db = new MonsterDBEntities(); 
        public List<Gender> GetGenders()
        {
            return db.Genders.ToList();
        }

        public bool InsertGender(Gender gender)
        {
            db.Genders.Add(gender);
          return  db.SaveChanges() > 0;
        }

        public bool InsertGender2(Gender gender)
        {
            var entry = db.Entry<Gender>(gender);

            entry.State = EntityState.Added;
                
           return db.SaveChanges() > 0;
        }

        public bool ChangeGender(Gender gender, EntityState State)
        {
            var entry = db.Entry<Gender>(gender);

            entry.State = State;

            return db.SaveChanges() > 0;
        }

        public void SearchGender()
        {
            var actives = db.Genders.Where(a => a.Active); // or a.Active == true
            var inactives = db.Genders.Where(a => !a.Active);
            var ma = db.Genders.Where(m => m.GenderName.Contains("ma"));
        }
    }
}


