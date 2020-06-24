using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticApp.RealtorsDataSet;

namespace PracticApp
{
    class Offer
    {

        public DatabaseRouter database;

        public Offer()
        {
            database = new DatabaseRouter("Offer");
        }

        public void Update(int clientID, int realtorID, int realtyID, decimal price, int id)
        {
            database.UpdateFieldsOffer(clientID, realtorID, realtyID, price, id);
        }

        public void Insert(int clientID, int realtorID, int realtyID, decimal price)
        {
            database.InsertOffer(clientID, realtorID, realtyID, price);
        }

        public void Delete(int id)
        {
            database.DeleteOffer(id);
        }

        public OfferDataTable GetData()
        {
            return (OfferDataTable)database.GetAllData();
        }

        public OfferRow GetDataByID(int id)
        {
            return (OfferRow)database.GetOfferByID(id);
        }


    }
}
