using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : Subject
    {
        private List<Observer> observers = new List<Observer>();
        private float temperature;
        private float humidity;
        private float pressure;

        
        public void notifyObserver()
        {
            foreach(Observer o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            if (observers.Count >= 0)
            {
                observers.Remove(o);
            }
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
