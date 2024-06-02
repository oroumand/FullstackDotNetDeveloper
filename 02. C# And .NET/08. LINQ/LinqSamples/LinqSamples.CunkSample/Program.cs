List<int> ints = Enumerable.Range(1, 100000).ToList();
var result = ints.Chunk(10);

Console.ReadLine();