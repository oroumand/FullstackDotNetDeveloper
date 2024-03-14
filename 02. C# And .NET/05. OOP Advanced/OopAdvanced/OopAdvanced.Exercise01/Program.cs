using OopAdvanced.Exercise01;

List<int> numbers = [1, 10, 20, 34, -10, -55, 123];
CommonCalculator commonCalculator = new CommonCalculator();
EvenCalculator evenCalculator = new EvenCalculator();
OddCalculator oddCalculator = new OddCalculator();
int commonResulst= commonCalculator.Calculate(numbers);
int evenResult = evenCalculator.Calculate(numbers);
int oddResult = oddCalculator.Calculate(numbers);

Console.WriteLine(commonResulst);
Console.WriteLine(evenResult);
Console.WriteLine(oddResult);
Console.ReadLine();