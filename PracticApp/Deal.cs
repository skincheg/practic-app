using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticApp.RealtorsDataSet;

namespace PracticApp
{
    class Deal
    {

        public DatabaseRouter database;

        public Deal()
        {
            database = new DatabaseRouter("Deal");
        }

        public void Delete(int id)
        {
            database.DeleteDeal(id);
        }

        public void Update(int demandId, int offerId, int id)
        {
            database.UpdateDeal(demandId, offerId, id);
        }

        public void NewDeal(int demandId, int offerId)
        {
            database.NewDeal(demandId, offerId);
        }

        public DealDataTable GetData()
        {
            return (DealDataTable)database.GetAllData();
        }
    }
}
