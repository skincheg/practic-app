using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticApp.RealtorsDataSet;

namespace PracticApp
{

    class Demand
    {
        public DatabaseRouter database;
        public string type;
        public Demand(string type)
        {
            database = new DatabaseRouter("Demand");
            this.type = type;
        }

        public DemandDataTable GetData()
        {
            return (DemandDataTable)database.GetDemand();
        }

        public DataRow GetDataByID(int id)
        {
            return database.GetFilterData(this.type, id);
        }

        public void Update(int clientID, int realtorID, string type, string address, int min, int max, int id)
        {
            database.UpdateDemand(clientID, realtorID, type, address, min, max, id);
        }

        public void UpdateHouse(int minFloors, int maxFloors, decimal minArea, decimal maxArea, int minRooms, int maxRooms, int id)
        {
            database.UpdateHouse(minFloors, maxFloors, minArea, maxArea, minRooms, maxRooms, id);
        }

        public void UpdateApartment(int minFloor, int maxFloor, decimal minArea, decimal maxArea, int minRooms, int maxRooms, int id)
        {
            database.UpdateApartment(minFloor, maxFloor, minArea, maxArea, minRooms, maxRooms, id);
        }

        public void UpdateLand(decimal minArea, decimal maxArea, int id)
        {
            database.UpdateLand(minArea, maxArea, id);
        }

    }
}
