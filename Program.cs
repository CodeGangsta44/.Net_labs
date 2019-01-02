using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person per1 = new Person("Roman", "Dovhopoliuk", "02/27/2000");
            // Person per2 = new Person();
            //
            // per1.printFullInfo();
            // per2.printFullInfo();

            Examination ex1 = new Examination();
            Examination ex2 = new Examination(1, "Matan", "Orlovski", 83, true, "01/10/2018");

            Examination[] arr = new Examination[2];
            arr[0] = ex1;
            arr[1] = ex2;

            // Console.WriteLine(ex1);
            // Console.WriteLine(ex2);

            Student st1 = new Student();

            st1.addExams(arr);
            Console.WriteLine(st1.avarage_rating);
            Console.WriteLine(st1);
            st1.PrintFullInfo();
        }
    }
}
