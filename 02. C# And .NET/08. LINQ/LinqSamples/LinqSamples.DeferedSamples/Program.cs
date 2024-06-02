List<int> ints = [1, 2, 3, 4, 5,6,7,8,9,10];
var moreThan7 = ints.Where(c => c > 7).ToList();

foreach (var i in moreThan7)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------------------------");
ints.Add(12);
ints.Add(13);
ints.Add(14);
ints.Add(15);

foreach (var i in moreThan7)
{
    Console.WriteLine(i);
}

Console.ReadLine();