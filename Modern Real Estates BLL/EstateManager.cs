using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modern_Real_Estates_BLL;
using Modern_Real_Estates_DAL;

namespace Modern_Real_Estates_DAL
{
    [Serializable]
    public class EstateManager : ListManager<Estate>
    {
        public EstateManager()
        {
            //Use methods from list manager.
        }
    }
}
