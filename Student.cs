using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_01 {
  public class Student : Person, ICloneable {

    public enum Education {
      Bachelor,
      Master,
      SecondEducation,
      PhD
    }

    public Education level {get; set;}
    public string group_name {get; set;}
    public int gradebook_number {get; set;}
    private List<Examination> list;

    public Student() : base() {
      this.level = Education.Bachelor;
      this.group_name = "IP-71";
      this.gradebook_number = 8;
      this.list = new List<Examination>();
    }

    public Student(string name, string surname, string date_of_birth, Education level,
      string group_name, int gradebook_number) : base(name, surname, date_of_birth){
        this.level = level;
        this.group_name = group_name;
        this.gradebook_number = gradebook_number;
        this.list = new List<Examination>();
    }

    public float avarage_rating {
      get {
        List<Examination> exams = this.list.FindAll(item => item.is_diff);
        int summ = 0;
        foreach (Examination exam in exams) summ += exam.points;
        return ((float)summ)/exams.Count;
      }
    }

    public void AddExams(Examination[] exams) {
      foreach (Examination item in exams) this.list.Add(item);
    }

    public override string ToString() {
      StringBuilder result = new StringBuilder();
      result.Append("Name: " + this.name + '\n');
      result.Append("Surname: " + this.surname + '\n');
      result.Append("Group number: " + this.group_name.Split('-')[1] + '\n');
      return result.ToString();
    }

    public override void PrintFullInfo() {
      Console.WriteLine("Student:");
      base.PrintFullInfo();
      Console.WriteLine("Education level: " + this.level);
      Console.WriteLine("Group name: " + this.group_name);
      Console.WriteLine("Gradebook number: " + this.gradebook_number);
      Console.WriteLine("\nExaminations:");
      foreach (Examination exam in this.list) Console.WriteLine(exam);
      Console.WriteLine("\nAvarage rating: " + this.avarage_rating);
    }

    public object Clone() {

      Student cloned = new Student(this.name, this.surname,
        this.date_of_birth.ToShortDateString(), this.level,
        this.group_name, this.gradebook_number);

      Examination[] exams = new Examination[this.list.Count];
      for (int i = 0; i < this.list.Count; i++){
        exams[i] = (Examination)this.list[i].Clone();
      }
      cloned.AddExams(exams);
      return cloned;
    }

    public IEnumerable<Examination> GetExamsLess(int max_point) {
      foreach (Examination i in this.list){
        if (i.points < max_point) yield return i;
      }
    }

    public Examination[] GetArrayOfExams() {
      Examination[] result = this.list.ToArray();
      Array.Sort(result);
      return result;
    }
  }
}
