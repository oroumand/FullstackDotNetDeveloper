List<int> ints = Enumerable.Range(1, 100000).ToList();
var contains = ints.Contains(100001);
Console.WriteLine(contains);
Console.ReadKey();