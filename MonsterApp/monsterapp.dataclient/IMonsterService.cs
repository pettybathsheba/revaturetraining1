using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using monsterapp.dataclient.Models;
using monsterapp.dataclient.NewFolder1;

namespace monsterapp.dataclient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMonsterService" in both code and config file together.
    [ServiceContract]
        public interface IMonsterService
    {
        //[OperationContract()]
       // [OperationBehavior()] 
        [OperationContract()]
        List<GenderDAO> GetGenders();

        [OperationContract()]
        List<TypeDAO> GetMonsterType();

        [OperationContract()]
        List<TitleDAO> GetTitles();
    }


}
