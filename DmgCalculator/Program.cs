namespace DmgCalculator
{
    internal class Program
    {
        static void Main()
        {
            SwordDamage swordDamage = new();

            while (true)
            {
                
                Console.WriteLine($"0 for no magic/flaming, 1 for magic, 2 for " +
                    $"flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey().KeyChar;
                if ((key != '1') & (key != '2') & (key != '3')) return;
                Console.WriteLine();
            }
        }
    }
}
