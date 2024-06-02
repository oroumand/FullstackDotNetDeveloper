using System.Reflection.Metadata.Ecma335;

namespace LinqSamples.WhatIs;
public class Studentd
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<int> Grades { get; set; }
    public static List<Studentd> GetStudentds()
    {
        return
        [
            new Studentd
            {
                Id = 1,
                FirstName="Alireza",
                LastName="Oroumand",
                Grades =[20,20,19,18,19]
            },
                        new Studentd
            {
                Id = 1,
                FirstName="Farid",
                LastName="Taheri",
                Grades =[20,17,19,18,19]
            }
            ,
            new Studentd
            {
                Id = 1,
                FirstName="Mohammad",
                LastName="Abbasi",
                Grades =[15,17,19,18,19]
            }
        ];
    }

    public static List<Studentd> GetStudentdsWithBadGrade()
    {
        return new List<Studentd>
        {
            new Studentd
            {
                Id = 1,
                FirstName="Alireza",
                LastName="Oroumand",
                Grades =[20,20,19,18,19]
            },
                        new Studentd
            {
                Id = 1,
                FirstName="Farid",
                LastName="Taheri",
                Grades =[20,17,19,18,19]
            }
            ,
            new Studentd
            {
                Id = 1,
                FirstName="Mohammad",
                LastName="Abbasi",
                Grades =[15,17,19,18,19]
            }
              ,
            new Studentd
            {
                Id = 1,
                FirstName="Amirhossein",
                LastName="Tayyareh",
                Grades =[15,10,19,8,19]
            }
        };
    }
}


