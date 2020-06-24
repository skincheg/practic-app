using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using static PracticApp.RealtorsDataSet;

namespace PracticApp
{
    class DatabaseRouter
    {
        public string type;
        public PracticApp.RealtorsDataSetTableAdapters.ClientsTableAdapter ClientsTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.RealtyTableAdapter RealtyTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.RealtyAddressesTableAdapter RealtyAddressesTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.ApartmentTableAdapter ApartmentTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.HouseTableAdapter HouseTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.LandTableAdapter LandTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.RealtyTypesTableAdapter RealtyTypesTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.OfferTableAdapter OfferTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.ApartmentFilterTableAdapter ApartmentFilterTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.HouseFilterTableAdapter HouseFilterTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.LandFilterTableAdapter LandFilterTableAdapter;
        public PracticApp.RealtorsDataSetTableAdapters.DemandTableAdapter DemandTableAdapter;


        public DatabaseRouter(string type)
        {
            this.type = type;

            switch(type)
            {
                case "Clients":
                    this.ClientsTableAdapter = new RealtorsDataSetTableAdapters.ClientsTableAdapter();
                    break;
                case "Realty":
                    this.RealtyTableAdapter = new RealtorsDataSetTableAdapters.RealtyTableAdapter();
                    this.RealtyAddressesTableAdapter = new RealtorsDataSetTableAdapters.RealtyAddressesTableAdapter();
                    this.ApartmentTableAdapter = new RealtorsDataSetTableAdapters.ApartmentTableAdapter();
                    this.HouseTableAdapter = new RealtorsDataSetTableAdapters.HouseTableAdapter();
                    this.LandTableAdapter = new RealtorsDataSetTableAdapters.LandTableAdapter();
                    this.RealtyTypesTableAdapter = new RealtorsDataSetTableAdapters.RealtyTypesTableAdapter();
                    break;
                case "Offer":
                    this.OfferTableAdapter = new RealtorsDataSetTableAdapters.OfferTableAdapter();
                    break;
                case "Demand":
                    this.ApartmentFilterTableAdapter = new RealtorsDataSetTableAdapters.ApartmentFilterTableAdapter();
                    this.HouseFilterTableAdapter = new RealtorsDataSetTableAdapters.HouseFilterTableAdapter();
                    this.LandFilterTableAdapter = new RealtorsDataSetTableAdapters.LandFilterTableAdapter();
                    this.DemandTableAdapter = new RealtorsDataSetTableAdapters.DemandTableAdapter();
                    break;
            }
            
        }

        public DataTable GetAllData()
        {
            switch (this.type)
            {
                case "Realty":
                    return this.RealtyAddressesTableAdapter.GetData();
                case "Offer":
                    return this.OfferTableAdapter.GetData();
                default:
                    return new DataTable();
            }
        }

        public DataTable GetFilterData(string type)
        {
            switch (type)
            {
                case "Apartment":
                    return this.ApartmentFilterTableAdapter.GetData();
                case "House":
                    return this.HouseFilterTableAdapter.GetData();
                case "Land":
                    return this.LandFilterTableAdapter.GetData();
                default:
                    return new DataTable();
            }
        }

        public DataTable GetDemand()
        {
            return DemandTableAdapter.GetData();
        }

        public void UpdateDemand(int clientID, int realtorID, string type, string address, int min, int max, int id)
        {
            DemandTableAdapter.UpdateDemand(clientID, realtorID, type, address, min, max, id);
        }

        public void UpdateHouse(int minFloors, int maxFloors, decimal minArea, decimal maxArea, int minRooms, int maxRooms, int id)
        {
            HouseFilterTableAdapter.UpdateHouse(minFloors, maxFloors, minArea, maxArea, minRooms, maxRooms, id);
        }

        public void UpdateApartment(int minFloor, int maxFloor, decimal minArea, decimal maxArea, int minRooms, int maxRooms, int id)
        {
            ApartmentFilterTableAdapter.UpdateApartment(minFloor, maxFloor, minArea, maxArea, minRooms, maxRooms, id);
        }

        public void UpdateLand(decimal minArea, decimal maxArea, int id)
        {
            LandFilterTableAdapter.UpdateLand(minArea, maxArea, id);
        }

        public DataRow GetFilterData(string type, int id)
        {
            switch (type)
            {
                case "Apartment":
                    return this.ApartmentFilterTableAdapter.GetDataByID(id).First();
                case "House":
                    return this.HouseFilterTableAdapter.GetDataByID(id).First();
                case "Land":
                    return this.LandFilterTableAdapter.GetDataByID(id).First();
                default:
                    return this.LandFilterTableAdapter.GetDataByID(id).First();
            }
        }

        public DataRow GetLastRow()
        {
            switch (this.type)
            {
                case "Realty":
                    return this.RealtyTableAdapter.GetData().Last();
                default:
                    return this.RealtyAddressesTableAdapter.GetData().Last();
            }
        }

        public DataRow GetDataByID(int id)
        {
            switch (this.type)
            {
                case "Realty":
                    return this.RealtyTableAdapter.GetDataByID(id).First();
                default:
                    return this.RealtyTableAdapter.GetData().First();
            }
        }

        public DataRow GetApartmentByID(int id)
        {
            return ApartmentTableAdapter.GetDataByID(id).First();
        }

        public DataRow GetHouseByID(int id)
        {
            return HouseTableAdapter.GetDataByID(id).First();
        }

        public DataRow GetLandByID(int id)
        {
            return LandTableAdapter.GetDataByID(id).First();
        }

        public DataRow GetAddressByID(int id)
        {
            return RealtyAddressesTableAdapter.GetDataByID(id).First();
        }

        public string TypeOfRealty(int id)
        {
            RealtyDataTable isApartment = RealtyTableAdapter.IsApartmentRealty(id);

            RealtyDataTable isHouse = RealtyTableAdapter.IsHouseRealty(id);

            RealtyDataTable isLand = RealtyTableAdapter.IsLandRealty(id);


            if (isApartment.Count != 0)
            {
                return "Apartment";
            }
            else if (isHouse.Count != 0)
            {
                return "House";
            }
            else if (isLand.Count != 0)
            {
                return "Land";
            }

            return "";
        }

        public DataTable GetDataByRealtyType(string typeRealty)
        {
            switch (typeRealty)
            {
                case "Apartment":
                    return this.RealtyTypesTableAdapter.GetDataByApartment();
                case "House":
                    return this.HouseTableAdapter.GetData();
                case "Land":
                    return this.LandTableAdapter.GetData();
                default:
                    return new DataTable();
            }
        }

        public DataTable GetAddressByRealtyType(string typeRealty)
        {
            switch (typeRealty)
            {
                case "Apartment":
                    return this.RealtyAddressesTableAdapter.GetAddressApartment();
                case "House":
                    return this.RealtyAddressesTableAdapter.GetAddressHouse();
                case "Land":
                    return this.RealtyAddressesTableAdapter.GetAddressLand();
                default:
                    return new DataTable();
            }
        }

        public void UpdateFieldsOffer(int clientID, int realtorID, int realtyID, decimal price, int id)
        {
            OfferTableAdapter.UpdateAllFields(clientID, realtorID, realtyID, price, id);
        }

        public void DeleteOffer(int id)
        {
            OfferTableAdapter.DeleteOffer(id);
        }

        public void InsertOffer(int clientID, int realtorID, int realtyID, decimal price)
        {
            OfferTableAdapter.NewOffer(clientID, realtorID, realtyID, price);
        }


        public void UpdateFieldsRealty(int latitude, int longitude, int id)
        {
            RealtyTableAdapter.UpdateAllFields(latitude, longitude, id);
        }

        public void UpdateAddress(string city, string street, string house, string flat, int id)
        {
            RealtyAddressesTableAdapter.UpdateAllFields(city, street, house, flat, id);
        }

        public void UpdateApartment(int floor, int rooms, decimal totalArea, int id)
        {
            ApartmentTableAdapter.UpdateAllFields(floor, rooms, totalArea, id);
        }

        public void UpdateHouse(int floor, int rooms, decimal totalArea, int id)
        {
            HouseTableAdapter.UpdateAllFields(floor, totalArea, rooms, id);
        }

        public void UpdateLand(decimal totalArea, int id)
        {
            LandTableAdapter.UpdateAllFields(totalArea, id);
        }

        public void DeleteRealty(int id)
        {
            RealtyTableAdapter.DeleteRealty(id);
        }

        public void AddAddress(string city, string street, string house, string flat, int id)
        {
            RealtyAddressesTableAdapter.Insert(id, city, street, house, flat);
        }

        public void AddRealty(int latitude, int longitude)
        {
            RealtyTableAdapter.AddRealty(latitude, longitude);
        }

        public void AddApartment(int id)
        {
            ApartmentTableAdapter.Insert(id, null, null, null);
        }

        public void AddHouse(int id)
        {
            HouseTableAdapter.Insert(id, null, null, null);
        }

        public void AddLand(int id)
        {
            LandTableAdapter.Insert(id, null);
        }



    }
}
