using System;

namespace Coding.Exercise
{
    public class Phone
    {
        public string Company;
        public string Model;
        public string ReleaseDay;

        // Place for your constructors
        public Phone()
        {
            Company = "Default";
            Model = "Default";
            ReleaseDay = "Default";
        }
        public Phone(string model, string company, string date)
        {
            this.Company = company;
            this.Model = model;
            this.ReleaseDay = date;
        }
        public Phone(string model, string company)
        {
            this.Company = company;
            this.Model = model;
        }
      

        public void Introduce()
        {
            Console.WriteLine("It is {0} created by {1}. It was released {2}.", Model, Company, ReleaseDay);
        }

    }

    public class Run
    {
        public static void RunExercise()
        {
            Phone one = new Phone();
            Phone two = new Phone("Apple", "IPhone 12");
            Phone three = new Phone("Apple", "IPhone 12", "September 24, 2021");

            one.Introduce();
            two.Introduce();
            three.Introduce();
        }

    }
}