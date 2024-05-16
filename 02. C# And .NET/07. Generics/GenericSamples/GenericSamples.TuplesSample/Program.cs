// See https://aka.ms/new-console-template for more information
using GenericSamples.TuplesSample;

Console.WriteLine("Hello, World!");

string myNumber = "dsfgdfg";

int myintNumber = int.Parse(myNumber);
int.TryParse(myNumber, out myintNumber);


List<int> numbers = [1, 2, 3, 4, 554, 3, 3, 4, 345, 345, 456, 4567, 234, 2345, 45];

Tuple<bool, int> MyTryPars(string input)
{
    //Convert
    return new Tuple<bool, int>(false, 1);
}


MyTowItemResult<int, int> FindMinMax(List<int> numbers)
{
    MyTowItemResult<int, int> result = new(0, 0);
    foreach (int number in numbers)
    {
        if (number < result.Item1)
        {
            result.Item1 = number;
        }
        else if (number > result.Item2)
        {
            result.Item2 = number;
        }
    }
    return result;
}

