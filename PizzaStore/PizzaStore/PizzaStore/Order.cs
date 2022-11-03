using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    internal class Order
    {
        #region Instance fields
        private static int nextId = 1;

        public int Id { get; set; }
        Customer _customer;
        Pizza _pizza;        
        //private double _totalPrice;

        #endregion



        #region Constructor
        public Order(Customer customer, Pizza pizza)
        {
            Id = nextId++;
            _customer = customer;
            _pizza = pizza;
        }
        

        #endregion




        #region Properties
        /*
        public double TotalPrice
        {
            get { return _totalPrice; }
        }
        */

        #endregion




        #region Methods

        public double CalculateTotalPrice(double price)     //Denne ville kunne returnere adskillige double values,
        {                                                   //Ex priser på soda, burger mm.
            return (price) * 1.25 + 40;
        }



        public override string ToString()
        {
            return $"{_customer}, {_pizza}, (with tax + delivery: {CalculateTotalPrice(_pizza.Price)})";
        }
        #endregion
    }
}
