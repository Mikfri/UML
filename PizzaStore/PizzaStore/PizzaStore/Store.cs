using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {
        #region Instance fields

        #endregion

        #region Constructor

        public Store()
        {

        }
        #endregion

        #region Properties


        #endregion

        #region Methods
        public static void Start()
        {
            Pizza pizza01 = new Pizza("01", "Magherita", 70.00);
            Pizza pizza02 = new Pizza("02", "Matador", 80.00);
            Pizza pizza03 = new Pizza("03", "Milano", 75.00);

            Customer customer01 = new Customer("Spongebob", "Bikini Bottom", "+45 80085111");
            Customer customer02 = new Customer("Mikkel Friborg", "Fynsvej 14, 4060", "+45 81183394");
            Customer customer03 = new Customer("Leroy Jenkins", "Azeroth", "+45 96785623");

            Adress adress01 = new Adress("Conch Street", "124", "Bikini Bottom", "3560");
            Adress adress03 = new Adress("Scarlet Raven Tavern", "7", "Eastern Kingdom", "0581");

            Order order01 = new Order(customer01, pizza02);
            Order order02 = new Order(customer02, pizza01);
            Order order03 = new Order(customer03, pizza03);

            Console.WriteLine(order01);
            Console.WriteLine(order02);
            Console.WriteLine(order03);
        }

        #endregion


    }
}
