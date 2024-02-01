using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9
{
    public class City
    {
        //campuri
        private string _cityName;
        private Coordinates _coordinates;

        //constructor
        public City(string cityName, (byte x, byte y) coordinates)
        {
            _cityName = cityName;
            _coordinates = new Coordinates(coordinates.x, coordinates.y);
        }

        //proprietati
        public string CityName
        {
            get { return _cityName; }
        }

        public Coordinates Coordinates
        {
            get { return _coordinates; }
        }

        //metode
        public void PrintCityToConsole()
        {
            Console.WriteLine($"{_cityName} ({_coordinates.X}, {_coordinates.Y})");
        }
    }
}
