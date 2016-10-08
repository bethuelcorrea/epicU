using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_046
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            Car car1 = new Car("BMW", "528i", 2010, "Black");
            Car car2 = new Car("BMW", "745li", 2005, "Black");
            Car car3 = new Car("Ford", "Escape", 2008, "White");

            List<Car> cars = new List<Car>()//;

            //cars.Add(car1);
           // cars.Add(car2);
           // cars.Add(car3);
           // var cars = new List<Car>()
            {
                new Car() {Make="BMW",Model="528i",Year=2010,Color="black" },
                new Car() { Make="Ford",Model="Ranger",Year=2010,Color="black"},
                new Car() { Make = "Mazda",Model = "626",Year = 2015,Color = "black"}
            };

            //List<Car> whiteCars = cars.FindAll(p => p.Color == "White");
            //cars.ForEach(p => p.Color = "Silver");
            //if (cars.Exists(p => p.Year == 2008))
            //    result += "We do have a 2008 model year in stock!";

            foreach (var car in cars)
            {
                result += car.FormatDetailsForDisplay();
            }


           for (int i = 0; i < cars.Count; i++)
           {
                var car = cars.ElementAt(i);

                result += car.FormatDetailsForDisplay();
           }


            resultLabel.Text = result;
        }
    }
}
