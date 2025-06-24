namespace TrafficSignalEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Signal(TrafficLight.Red));
            Console.WriteLine(Signal(TrafficLight.Green));
            Console.WriteLine(Signal(TrafficLight.Yellow));

        }

        static string Signal(TrafficLight Light)
        {
            switch (Light)
            {
                case TrafficLight.Red:
                    return "Red->Stop";
                 

                case TrafficLight.Green:
                    return "Green->Go";

                case TrafficLight.Yellow:
                    return "Yellow->Get ready";

                default:

                    return "Invalid data detected.";


            }
    
        }
    }

    public enum TrafficLight
    {
        Red,
        Yellow,
        Green,

    }

    
}
