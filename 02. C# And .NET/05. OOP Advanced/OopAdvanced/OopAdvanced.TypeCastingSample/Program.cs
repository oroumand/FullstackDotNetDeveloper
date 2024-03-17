//double mydouble = 12.5;
//decimal mydecimal = 25.5m;//money

////mydecimal = mydouble;
////mydouble = mydecimal;

//int myint = 12;
////implicit type casting
//mydecimal = myint;
////explicity type casting
//myint = (int)mydecimal;

//DayOfWeek myDay = DayOfWeek.Yekshanbe;

//int myIntDay = (int)myDay;

//DayOfWeek shanbe = (DayOfWeek)11;

//public enum DayOfWeek
//{
//    Shanbe,
//    Yekshanbe,
//    Jome
//}
//Parent Parent1 = new Parent();
//Child Child1 = new Child();
//ChildTemp childTemp1 = new ChildTemp();


//Parent parent = Child1;

//Child child = (Child)parent;

//Parent pchild = new Child();

//Parent pChildTemp = new ChildTemp();

//bool isChild = pChildTemp is Child;
//bool isChild2 = pchild is Child;

//if (isChild)
//{
//    Child ch = (Child)pChildTemp;
//}
//Parent parent = new Parent();
//Console.WriteLine(parent.age);
//Console.WriteLine(parent.birthDay);
//Console.WriteLine(parent.name.FirstName);

Parent pchild = new Child();

Parent pChildTemp = new ChildTemp();

Child c1 = pchild as Child;
Child c2 = pChildTemp as Child;

if(c2 != null)
{

}
if(c2 is not null)
{

}


Console.ReadLine();

public class Parent
{
    public int age;
    public DateTime birthDay;
    public FullName name;
}

public class FullName
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Child:Parent
{

}

public class ChildTemp: Parent
{

}