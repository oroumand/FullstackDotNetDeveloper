int myVariable = 10;
int myVariableOut;
AddNumberByRef(ref myVariable);
AddNumberByRefWithOut(out myVariableOut);
Console.WriteLine(myVariable);
Console.WriteLine(myVariableOut);
Console.WriteLine("---------------------------");
List<int> ints = [1, 2, 3, 4];
AddToList(ref ints);
foreach (int i in ints)
{
    Console.WriteLine(i);
}
Console.ReadLine();



void AddNumberByRef(ref int number)
{

}

bool AddNumberByRefWithOut(out int number)
{
    number = 123;
    return true;
}

void AddToList(ref List<int> list)
{
    //list.Add(DateTime.Now.Day);
    //list.Add(DateTime.Now.Second);
    //list.Add(DateTime.Now.Millisecond);
    list = null;
}