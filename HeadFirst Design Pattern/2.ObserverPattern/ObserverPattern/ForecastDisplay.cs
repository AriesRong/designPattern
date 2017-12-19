using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float temp;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current conditions:" + temp.ToString() + "F degrees.");
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            display();
        }
    }
}
