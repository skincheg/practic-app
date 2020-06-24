using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticApp.RealtorsDataSet;

namespace PracticApp
{
    class Realty
    {
        public DatabaseRouter database;

        public Realty()
        {
            database = new DatabaseRouter("Realty");
        }

        public RealtyAddressesDataTable GetAllRealty()
        {
            return (RealtyAddressesDataTable)database.GetAllData();
        }

        public RealtyRow GetCoordinatesByID(int id)
        {
            return (RealtyRow)database.GetDataByID(id);
        }

        public RealtyAddressesRow GetAddressByID(int id)
        {
            return (RealtyAddressesRow)database.GetAddressByID(id);
        }

        public ApartmentRow GetApartmentByID(int id)
        {
            return (ApartmentRow)database.GetApartmentByID(id);
        }

        public HouseRow GetHouseByID(int id)
        {
            return (HouseRow)database.GetHouseByID(id);
        }

        public LandRow GetLandByID(int id)
        {
            return (LandRow)database.GetLandByID(id);
        }

        public RealtyTypesDataTable GetDataByRealtyType(string type)
        {
            return (RealtyTypesDataTable)database.GetDataByRealtyType(type);
        }

        public RealtyAddressesDataTable GetAddressByRealtyType(string type)
        {
            return (RealtyAddressesDataTable)database.GetAddressByRealtyType(type);
        }

        public string TypeOfRealty(int id)
        {
            return database.TypeOfRealty(id);
        }

        public void UpdateFieldsRealty(int latitude, int longitude, int id)
        {
            database.UpdateFieldsRealty(latitude, longitude, id);
        }

        public void UpdateAddress(string city, string street, string house, string flat, int id)
        {
            database.UpdateAddress(city, street, house, flat, id);
        }

        public void UpdateApartment(int floor, int rooms, decimal totalArea, int id)
        {
            database.UpdateApartment(floor, rooms, totalArea, id);
        }

        public void UpdateHouse(int floor, int rooms, decimal totalArea, int id)
        {
            database.UpdateHouse(floor, rooms, totalArea, id);
        }

        public void UpdateLand(decimal totalArea, int id)
        {
            database.UpdateLand(totalArea, id);
        }

        public void DeleteRealty(int id)
        {
            database.DeleteRealty(id);
        }

        public void AddAddress(string city, string street, string house, string flat, int id)
        {
            database.AddAddress(city, street, house, flat, id);
        }

        public void AddRealty(int latitude, int longitude)
        {
            database.AddRealty(latitude, longitude);
        }

        public RealtyRow GetLastRealty()
        {
            return (RealtyRow)database.GetLastRow();
        }

        public void AddTypeOfRealty(int id, string typeRealty)
        {
            switch (typeRealty)
            {
                case "Apartment":
                    database.AddApartment(id);
                    break;
                case "House":
                    database.AddHouse(id);
                    break;
                case "Land":
                    database.AddLand(id);
                    break;
                default:
                    return;
            }
        }


    }
}
