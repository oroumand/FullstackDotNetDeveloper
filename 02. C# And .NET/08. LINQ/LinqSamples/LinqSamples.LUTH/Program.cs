List<string> names = ["Alireza", "Hassan", "Mohammad", "Farid"];
List<int> numbers = [2, 3, 4, 6, 8, 9, 10];

bool thereIsMasoud = names.Any(c => c == "Masoud");
var oddNumbers = numbers.Where(c => c % 2 != 0).ToList();
Console.WriteLine(thereIsMasoud);
foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}
Console.ReadLine();


