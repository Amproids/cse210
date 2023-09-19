using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Salesman";
        job1._company = "KFC";
        job1._startYear = 2020;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Valve";
        job2._startYear = 2021;
        job2._endYear = 2023;

        Resume myresume = new Resume();
        myresume._name = "Andrew Parry";
        myresume._Jobs.Add(job1);
        myresume._Jobs.Add(job2);
        myresume.Display();
    }
}