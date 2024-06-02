using LinqSamples.WhatIs;

var goodStudents = Studentd.GetStudentds();
bool result01 = HasBadGradeLINQ(goodStudents);
var badstudents = Studentd.GetStudentdsWithBadGrade();
bool result02 = HasBadGradeLINQ(badstudents);
Console.WriteLine($"The first list has bad students? {result01}");
Console.WriteLine($"The seccond list has bad students? {result02}");
var a = goodStudents.Min(c => c.Id);
var b = goodStudents.MinBy(c => c.Id);
Console.ReadLine();
bool HasBadGradeLINQ(List<Studentd> studentds)
{
    return studentds.Any(c => c.Grades.Any(a => a < 10));
}
bool HasBadGrade(List<Studentd> studentds)
{
    bool hasBadScore = false;
    foreach (Studentd studentd in studentds)
    {
        foreach (var grade in studentd.Grades)
        {
            if (grade < 10)
            {
                hasBadScore = true;
            }
        }
    }
    return hasBadScore;
}
