﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData : Subject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }
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