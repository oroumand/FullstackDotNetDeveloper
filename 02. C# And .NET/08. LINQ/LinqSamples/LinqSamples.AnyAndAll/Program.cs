List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

var numberMoreThan7 = numbers.Any(c=>c > 7);
Console.WriteLine(numberMoreThan7);
var allNumberMoreThan7 = numbers.All(c => c > 0);
Console.WriteLine(allNumberMoreThan7);

Console.ReadLine();