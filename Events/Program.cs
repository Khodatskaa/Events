namespace Events
{
    public class DaytimeTemperature
    {
        public int Day { get; set; }
        public int HighestTemperature { get; set; }
        public int LowestTemperature { get; set; }

        public int TemperatureDifference()
        {
            return HighestTemperature - LowestTemperature;
        }
    }

    public class Program
    {
        static void Main()
        {
            DaytimeTemperature[] temperatures = new DaytimeTemperature[]
            {
                new DaytimeTemperature { Day = 1, HighestTemperature = 25, LowestTemperature = 10 },
                new DaytimeTemperature { Day = 2, HighestTemperature = 30, LowestTemperature = 15 },
                new DaytimeTemperature { Day = 3, HighestTemperature = 20, LowestTemperature = 5 },
                new DaytimeTemperature { Day = 4, HighestTemperature = 28, LowestTemperature = 12 },
                new DaytimeTemperature { Day = 5, HighestTemperature = 22, LowestTemperature = 8 }
            };

            int maxDifference = 0;
            foreach (var temperature in temperatures)
            {
                int difference = temperature.TemperatureDifference();
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                }
            }

            Console.WriteLine("Days with the maximum temperature difference:");
            foreach (var temperature in temperatures)
            {
                if (temperature.TemperatureDifference() == maxDifference)
                {
                    Console.WriteLine($"Day {temperature.Day}");
                }
            }
        }
    }
}
