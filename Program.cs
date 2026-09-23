Console.Write("Character name: ");
string charName = Console.ReadLine();
Console.Write("EXP gained per battle: ");
int exp = int.Parse(Console.ReadLine());
Console.Write("Number of Battles: ");
int totalBattles = int.Parse(Console.ReadLine());

for (int battles = 1; battles <= totalBattles; battles++)
{
    Console.WriteLine($"Battle {battles} | EXP gained: {exp} | Total EXP: {exp * battles}");
    if (exp % 100==0)
    {
        Console.WriteLine($"*** Milestone reached! Total EXP: {exp} ***");
    }
}
Console.WriteLine();
Console.WriteLine("=== Battle Complete ===");
Console.WriteLine($"Character  : {charName}\nBattles    : {totalBattles}\nTotal EXP  : {exp * totalBattles}");