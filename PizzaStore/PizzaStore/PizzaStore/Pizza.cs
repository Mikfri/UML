using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Pizza
    {
        #region Instance fields

        private string _pizzaNo;
        string _name;       
        double _price;

        #endregion

        #region Constructor
        public Pizza(string pizzaNo, string name, double price)
        {
            _pizzaNo = pizzaNo;
            _name = name;
            _price = price;
        }
        #endregion


        #region Properties

        public double Price     //Property Price er nødvendig så den kan calles
        {
            get { return _price; }
            //set { _price = _price * 1.25 + 40; }
        }
       
        #endregion


        #region Methods

        public override string ToString()
        {
            return "Pizza# " + _pizzaNo + ": " + _name + ", price is: " + _price + "\n";
        }
        #endregion

    }

}