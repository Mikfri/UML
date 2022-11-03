using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Customer
    {
        #region Instance fields
        private static int nextId = 1;

        private int Id { get; set; }
        string _name;
        string _adress;
        string _phone;
        #endregion


        #region Constructor
        public Customer(string name, string adress, string phone)
        {
            Id = nextId++;
            _name = name;
            _adress = adress;
            _phone = phone;
        }

        public Customer()
        {
            Id = nextId++;
        }
        #endregion



        #region Properties

        #endregion



        #region Methods
        public override string ToString()
        {
            return "Customer: " + _name + ", adress: " + _adress+"\n";
        }

        #endregion

    }
}
