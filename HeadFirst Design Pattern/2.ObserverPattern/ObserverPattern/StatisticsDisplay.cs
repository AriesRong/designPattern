using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        private float tem;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current conditions:" + tem.ToString() + "F degrees ");
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.tem = temp;
            display();
        }
    }
}
