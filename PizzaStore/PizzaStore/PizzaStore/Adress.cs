using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Adress
    {
        #region Properties
        public string RoadName { get; set; }
        public string RoadNumb { get; set; }
        public string CityName { get; set; }
        public string PostNumb { get; set; }

        #endregion

        #region Constructor
        public Adress(string roadName, string roadNumb, string cityName, string postNumb)
        {
            RoadName = roadName;
            RoadNumb = roadNumb;

        }

        public Adress()
        {

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{{{nameof(RoadName)}={RoadName}, {nameof(RoadNumb)}={RoadNumb}, {nameof(CityName)}={CityName}, {nameof(PostNumb)}={PostNumb}}}";
        }
        #endregion
    }

}