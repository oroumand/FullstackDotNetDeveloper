using GenericSamples.FuncAndActions;

Person person = new();
int age = 10;

List<int> ints = [1, 2, 3, 4, 5, 6, 7, 8, 9];



bool hasOdd = CheckAny(ints, input=> input % 2 == 0);
Console.WriteLine($"There is Odd Number: {hasOdd}");



bool hasEven = CheckAny(ints, input =>  input % 2 == 0);
Console.WriteLine($"There is even Number: {hasEven}");


bool hasGT100 = CheckAny(ints, (input) => input > 1000);
Console.WriteLine($"There is Number grater than 100: {hasEven}");



//bool HasOddNumber(List<int> ints)
//{
//    foreach (int i in ints)
//    {
//        if (i % 2 != 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//bool HasEvenNumber(List<int> ints)
//{
//    foreach (int i in ints)
//    {
//        if (i % 2 == 0)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//bool HasGraterThan100(List<int> ints)
//{
//    foreach (int i in ints)
//    {
//        if (i > 100)
//        {
//            return true;
//        }
//    }
//    return false;
//}
bool CheckAny(List<int> ints, Func<int, bool> expression)
{
    foreach (int i in ints)
    {
        if (expression(i))
        {
            return true;
        }
    }
    return false;
}

//bool Check(int input) => true;
//bool HasOdd(int input) => input % 2 != 0;
//bool HasEven(int input) => input % 2 == 0;
////bool HasGT100(int input) => input > 100;
//bool HasGT1000(int input) => input > 1000;







