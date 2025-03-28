using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week6.Abstraction.Polymorphism
{
    // Polimorfizm örneği
    public class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }

        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public virtual decimal CalculateSalary()
        {
            return BaseSalary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Çalışan: {Name}, Maaş: {CalculateSalary():C}");
        }
    }

    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public Manager(string name, decimal baseSalary, decimal bonus) : base(name, baseSalary)
        {
            Bonus = bonus;
        }

        public override decimal CalculateSalary()
        {
            // Temel metodu çağırıp üzerine bonus ekliyor
            return base.CalculateSalary() + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Yönetici: {Name}, Maaş: {CalculateSalary():C}, Bonus: {Bonus:C}");
        }
    }

    public class Developer : Employee
    {
        public int ProjectsCompleted { get; set; }
        public decimal ProjectBonus { get; set; }

        public Developer(string name, decimal baseSalary, int projectsCompleted, decimal projectBonus)
            : base(name, baseSalary)
        {
            ProjectsCompleted = projectsCompleted;
            ProjectBonus = projectBonus;
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + (ProjectsCompleted * ProjectBonus);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Geliştirici: {Name}, Maaş: {CalculateSalary():C}, Projeler: {ProjectsCompleted}");
        }
    }

    //internal class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        // Çalışanlar
    //        Employee employee = new Employee("Ahmet", 5000);
    //        Manager manager = new Manager("Mehmet", 7000, 2000);
    //        Developer developer = new Developer("Ayşe", 6000, 5, 1000);
    //        // Çalışanlar dizisi
    //        Employee[] employees = new Employee[] { employee, manager, developer };
    //        // Çalışan bilgilerini göster
    //        foreach (Employee emp in employees)
    //        {
    //            emp.DisplayInfo();
    //        }
    //    }
      
    //}
}
