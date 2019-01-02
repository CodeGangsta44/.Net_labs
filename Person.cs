using System;

namespace lab_01 {
  public class Person {

    protected string name;
    protected string surname;
    protected DateTime date_of_birth;

    public int year_of_birth {
      get { return this.date_of_birth.Year; }

      set {
        int year = value;
        int month = this.date_of_birth.Month;
        int day = this.date_of_birth.Day;

        this.date_of_birth = new DateTime(year, month, day);
      }
    }

    public Person() {
      this.name = "Linus";
      this.surname = "Torvalds";
      this.date_of_birth = new DateTime(1969, 12, 28);
    }

    public Person(string name, string surname, string date_of_birth) {
      this.name = name;
      this.surname = surname;
      this.date_of_birth = Convert.ToDateTime(date_of_birth);
    }

    public virtual void PrintFullInfo() {
        Console.WriteLine("Name: " + this.name);
        Console.WriteLine("Surname: " + this.surname);
        Console.WriteLine("Date of birth: " + this.date_of_birth.ToLongDateString());
    }
  }
}
