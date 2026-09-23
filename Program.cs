Console.Write("Character name: ");
string charName = Console.ReadLine();
Console.Write("EXP gained per battle: ");
int exp = int.Parse(Console.ReadLine());

for (int battles = 1; battles <= 3; battles++)
{
    Console.WriteLine($"Battle {battles} | EXP gained: {exp} | Total EXP: {exp * battles}");
}
Console.WriteLine();
Console.WriteLine("=== Battle Complete ===");
Console.WriteLine($"Characther  : {charName}\nBattles     : 3\nTotal EXP   : {exp * 3}");