using System;

namespace PracticApp
{


    partial class RealtorsDataSet
    {
    }
}

namespace PracticApp.RealtorsDataSetTableAdapters
{
    partial class RealtyTableAdapter
    {
    }

    public partial class ClientsTableAdapter
    {
        public static explicit operator ClientsTableAdapter(PersonTableAdapter v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator ClientsTableAdapter(RealtyTableAdapter v)
        {
            throw new NotImplementedException();
        }
    }
}
