namespace CurrentDivider
{
    internal class Program
    {
        /// <summary>
        /// Current Divider Circuits.
        /// Inputs: 
        ///     1) Current: (Ampere),
        ///     2) The resistor value we want to find the current on,
        ///     3) The resistor that is connected in parallel.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Current (Ampere): ");
                var reuma = Double.Parse(Console.ReadLine().ToString());

                Console.Write("Wanted Resistor(Ohm): ");
                var zitoumeniAntistasi = Double.Parse(Console.ReadLine().ToString());

                Console.Write("Parallel Resistor(Ohm): ");
                var apentantiAntistasi = Double.Parse(Console.ReadLine().ToString());



                double result = reuma * apentantiAntistasi / (apentantiAntistasi + zitoumeniAntistasi);

                Console.WriteLine($"Current in wanted resistor is: {result} A");

                Console.Write("Continue?: ");
                var cont = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("\n");

                if (cont.Equals("n"))
                    Environment.Exit(0);
            }
        }
    }
}