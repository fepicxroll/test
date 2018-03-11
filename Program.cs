using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Adam", "Miś", new DateTime(1990, 3, 20, 12, 30, 10));
            Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 3, 5, 12345);
            Person person3 = new FootballPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "striker", "FC Barcelona", 10);
            person1.Details();
            person2.Details();
            person3.Details();
            Student student = new Student("Micha", "Kt", new DateTime(1990, 4, 13), 3, 5, 12345);
            student.Details();
            ((Player)person3).ScoreGoal();
            person3.Details();

            ((Student)person2).AddGrade("PO", 5.0D, new DateTime(2011, 2, 20));
            ((Student)person2).AddGrade("Bazy Danych", 5.0D, new DateTime(2011, 2, 13));
            person2.Details();

            Grade grade = new Grade("Bazy Danych", 5.0D, new DateTime(2011, 5, 1));
            student.AddGrade(grade);
            student.AddGrade("AWWW", 5.0D, new DateTime(2011, 5, 11));
            student.AddGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
            student.Details();
            student.DeleteGrade("AWWW", 4.5D, new DateTime(2011, 4, 2));
            student.Details();
            student.DeleteGrades("AWWW");
            student.Details();
            student.AddGrade("AWWW", 5.0D, new DateTime(2011, 4, 3));
            student.DeleteGrades();
            student.Details();

            Player footballer = new HandballPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "striker", "FC Politechnika");
           
            footballer.Details();
            
            footballer.ScoreGoal();
            footballer.ScoreGoal();
           
            footballer.Details();

            Console.ReadKey();
        }
    }
}
