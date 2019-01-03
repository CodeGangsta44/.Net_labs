using System;

namespace lab_01 {
  public class Person {

    public string name {get; set;}
    public string surname {get; set;}
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

    public override bool Equals(object obj) {
      Person item = (Person)obj;
      return String.Equals(this.name, item.name) &&
             String.Equals(this.surname, item.surname) &&
             String.Equals(this.date_of_birth.ToShortDateString(), item.date_of_birth.ToShortDateString());
    }

    public override int GetHashCode() {
      int result = this.name.Length + this.surname.Length;
      result += this.date_of_birth.ToLongDateString().Length;
      return result;
    }
  }
}
