using ConsoleApp1projekt21;

Employee employee1 = new Employee("mariusz","mariski",52);
Employee employee2 = new Employee("tomek","tonkiewicz",47 );
Employee employee3 = new Employee("Adam","Adamski",25 );
Employee employee4 = new Employee("jan", "jankoski", 77);

employee1.AddScore(1);
employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(4);

employee2.AddScore(1);
employee2.AddScore(44);
employee2.AddScore(3);
employee2.AddScore(4);

employee3.AddScore(41);
employee3.AddScore(46);
employee3.AddScore(33);
employee3.AddScore(4);

employee4.AddScore(2);
employee4.AddScore(2);
employee4.AddScore(2);
employee4.AddScore(2);

List<Employee> list = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

int MaxRezult = -1;
Employee employeeWithMaxRezult = null;

foreach (var employee in list)

{
    if (employee1.Rezult > MaxRezult)
    {
        employeeWithMaxRezult = employee1;
        MaxRezult = employee1.Rezult;
    }
    else if (employee2.Rezult > MaxRezult)
    {

        employeeWithMaxRezult = employee2;
        MaxRezult = employee2.Rezult;
    }
    else if (employee3.Rezult > MaxRezult)
    {
        employeeWithMaxRezult = employee3;
        MaxRezult = employee3.Rezult;
    }
    else if (employee4.Rezult > MaxRezult)
    {
        employeeWithMaxRezult = employee4;
        MaxRezult = employee4.Rezult;
    }
}
Console.WriteLine("Pracownik z najwyzsza iloscią punktów: " +  employeeWithMaxRezult.imie+" " +employeeWithMaxRezult.nazwisko);
Console.WriteLine("wiek " +employeeWithMaxRezult.wiek+" "+"ilość wypracowanych punktów "+ employeeWithMaxRezult.Rezult);
