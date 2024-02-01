namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definirea celor 5 orase
            City cluj = new City("Cluj", (2, 3));
            City huedin = new City("Huedin", (4, 8));
            City dej = new City("Dej", (5, 2));
            City bucuresti = new City("Bucuresti", (4, 1));
            City sibiu = new City("Sibiu", (0, 6));

            City[] citiesList = new City[] { cluj, huedin, dej, bucuresti, sibiu };

            //afisarea oraselor si citirea unui oras ales din input
            Console.WriteLine("Choose a name of a city between: ");
            for (byte i = 0;  i < citiesList.Length; i++)
            {
                Console.Write($"{i+1}. "); 
                citiesList[i].PrintCityToConsole();
            }
            string userInput = Console.ReadLine();

            //verificarea orasului ales de user in array-ul de orase
            City givenCity = null;

            for (byte i = 0; i < citiesList.Length; i++)
            {
                if (userInput == citiesList[i].CityName)
                {
                    givenCity = citiesList[i];
                    break;
                }
            }

            //verificarea celui mai apropiat oras fata de cel ales de user
            double minDistance = 20;
            City nearestCity = null;

            for (byte i = 0; i < citiesList.Length; i++)
            {   
                if (givenCity != citiesList[i])
                {
                    double distance = DistanceCalculator.CalculateDistance(citiesList[i].Coordinates, citiesList[(i + 1) % citiesList.Length].Coordinates);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        nearestCity = citiesList[i];
                    }
                }
            }

            //afisarea celui mai apropiat oras
            Console.WriteLine($"The nearest city from {givenCity.CityName} is: {nearestCity.CityName}");
        }
    }
}