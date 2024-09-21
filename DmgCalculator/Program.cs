namespace DmgCalculator
{
    internal class Program
    {
        static void Main()
        {
            SwordDamage swordDamage = new();

            while (true)
            {
                
                Console.Write($"0 for no magic/flaming, 1 for magic, 2 for " +
                    $"flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey(false).KeyChar;
                if ((key != '0') & (key != '1') & (key != '2') & (key != '3')) return;

                swordDamage.Roll = Random.Shared.Next(1, 7) + Random.Shared.Next(1, 7) +
                    Random.Shared.Next(1, 7);
                if (key == '1' || key == '3') swordDamage.SetMagic(true);
                else swordDamage.SetMagic(false);
                if (key == '2' || key == '3') swordDamage.SetFlaming(true);
                else swordDamage.SetFlaming(false);
                Console.WriteLine($"\nRolled {swordDamage.Roll} " +
                    $"for {swordDamage.Damage} HP");


            }
        }
    }
}
