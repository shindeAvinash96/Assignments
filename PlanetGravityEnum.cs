namespace PlanetGravityEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Earthweight = 70;

            Console.WriteLine("Weight on Mars:  "+equivalentWeight(Earthweight,3.71));
            Console.WriteLine("Weight on Jupiter:  " + equivalentWeight(Earthweight, 24.79));

        }

        static double equivalentWeight(double Earthweight, double planetGravity)
        {
            double EarthGravity = 9.8;
            return Earthweight * (planetGravity / EarthGravity);
        }
    }

    public enum Planet 
    {
        Earth,
        Mars,
        Jupiter
    }


}
