var AliAge = 45;
var HosseinAge = 45;
var IsAliGrater = AliAge > HosseinAge;
var IsHosseinGrater = AliAge < HosseinAge;
if (IsAliGrater)
{
    Console.WriteLine("Ali is grater than Hossein");
}
else if (IsHosseinGrater)
{
    Console.WriteLine("Hossin is grater than Ali");
}
else
{
    Console.WriteLine("They are in the same age");
}

Console.ReadLine();