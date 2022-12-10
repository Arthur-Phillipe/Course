using ArtSofLibrary.Talk;
using System;
using Course.Entities.Enums;
using Course.Entities;

namespace Course
{
    internal class Program : TalkFunctions
    {
        static void Main(string[] args)
        {
        // pede dados do departamento e do trabalhador
            string deptName = Ask("\nEnter departament´s name: ");
            Say("Enter worker data.\n");
            string name = Ask("Name: ");
            string s = Ask("Level (Junior/MidLevel/Senior): "); 
            //  ++ ATENÇÃO ++ substituir por uma função de ArtSoftLibrary
            WorkerLevel level = 
            (WorkerLevel)Enum.Parse(typeof(WorkerLevel), s);
            double baseSalary = AskDouble("Base salary: ");
        //cria as ínstâncias dept e trabalhador
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            int n = AskInt("\nHow many contracts to this worker? ");
            for (int i=1; i<=n; i++)
            {
                Say($"\nEnter {i}º contract data: \n");
                DateTime date = AskDate("Date (DD/MM/YYY): ");
                double valuePerHour = AskDouble("Value per hour: ");
                int hours = AskInt("Duration (hours): ");
                HourContract contract = new HourContract(date, valuePerHour, hours);  
                worker.AddContract(contract);
            }
            string monthYear = Ask("Enter month and year to calculete income (MM/YYYY): ");
            int month = int.Parse(monthYear.Substring(0, 2));
            // não colocando o tamanho ele pega a substring até o fim
            int year = int.Parse(monthYear.Substring(3));

            // Exibir os dados do trabalhador
            Say("Name: " + worker.Name);
            Say("\nDepartment: " + worker.Department.Name);
            Say("\nIncome for " + monthYear + ": " + 
                worker.Income(year, month).ToString("F2"));

          Ask("\nPush <enter> to quit.");

        }
    }
}
