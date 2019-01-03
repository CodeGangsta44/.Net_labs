using System;

namespace lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* пукт А */

            Console.WriteLine("\n Part A:");

            Student stud1 = new Student();
            stud1.name = "Roman";
            stud1.surname = "Dovhopoliuk";
            stud1.year_of_birth = 2000;
            stud1.level = Student.Education.Bachelor;
            stud1.group_name = "IP-71";
            stud1.gradebook_number = 8;

            // Альтернативний варіант:
            // Student stud1 = new Student("Roman", "Dovhopoliuk", "02/27/2000",
            //                 Student.Education.Bachelor, "IP-71", 8);

            Console.WriteLine(stud1);

            /* Пункт B */

            Console.WriteLine("\n Part B:");

            Examination[] arr = new Examination[4]{
              new Examination(),
              new Examination(1, "Matan", "Orlovski", 83, true, "01/10/2018"),
              new Examination(2, "Physics", "Linchevski", 89, true, "05/13/2018"),
              new Examination(1, "LinAl", "Prohorenko", 79, true, "12/21/2017")
            };

            stud1.AddExams(arr);

            /* Пункт C */

            Console.WriteLine("\n Part C:");

            stud1.PrintFullInfo();

            /* Пункт D */

            Console.WriteLine("\n Part D:");

            // завдання #1

            Console.WriteLine("\n Task #1:");

            Student stud2 = (Student)stud1.Clone();
            stud1.PrintFullInfo(); // власивості об'єктів однакові
            stud2.PrintFullInfo();

            stud1.year_of_birth = 1900; // змінюємо значення властивостей першого об'єкта
            stud1.AddExams(arr);

            stud1.PrintFullInfo(); // власивості об'єктів різні, що вказує на те, що було проведенл глибоке клонування
            stud2.PrintFullInfo();

            // завдання #2

            Console.WriteLine("\n Task #2:");

            Person per1 = new Person();
            Person per2 = new Person();
            Person per3 = new Person("Roman", "Dovhopoliuk", "02/27/2000");

            Console.WriteLine(per1);
            Console.WriteLine(per2);
            Console.WriteLine(per3);

            Console.WriteLine(per1 == per2); // посилання на об'єкти різні, але значення власивостей однакові
            Console.WriteLine(per1 != per3); // посилання на об'єкти різні, та значення власивостей різні

            // завдання #6

            Console.WriteLine("\n Task #6:");

            foreach (Examination i in stud2.GetExamsLess(85)) Console.WriteLine(i); // ітератор для іспитів із кількістю балів меншою, ніж задана

            // завдання #10

            Console.WriteLine("\n Task #10:");

            Examination[] result = stud2.GetArrayOfExams(); // метод, що повертає масив відсоротованих за номером семестра іспитів/заліків
            foreach(Examination i in result) Console.WriteLine(i);

        }
    }
}
