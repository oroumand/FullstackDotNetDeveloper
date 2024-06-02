List<int> ints = [1, 2, 3, 4, 5];
List<string> names = ["Alireza", "Oroumand"];
Dictionary<string, string> fullNames = new();
fullNames["a"] = "a";
fullNames["b"] = "b";
fullNames["c"] = "c";
fullNames["d"] = "d";

var nums = ints.Where(c=>c%2==0).Any(c=>c == 4);
//foreach(int i in nums)
//{
//    Console.WriteLine(i);
//}
Console.ReadLine();