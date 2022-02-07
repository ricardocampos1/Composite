// See https://aka.ms/new-console-template for more information
using Composite.Composite;
using Composite.Leaf;

Employee Thiago = new() { EmpID = 1, Name = "Thiago" };
Employee Gabriel = new() { EmpID = 2, Name = "Gabriel" };
Employee Jones = new() { EmpID = 3, Name = "Jones" };

Thiago.AddSubordinate(Gabriel);
Thiago.AddSubordinate(Jones);

Employee Barbara = new() { EmpID = 4, Name = "Barbara" };
Employee Andre = new() { EmpID = 5, Name = "André" };

Gabriel.AddSubordinate(Barbara);
Gabriel.AddSubordinate(Andre);

Employee Cesar = new() { EmpID = 6, Name = "Cesar" };
Employee Igor = new() { EmpID = 7, Name = "Igor" };

Contractor Gisnando = new() { EmpID = 8, Name = "Gisnando" };
Contractor Gerlandio = new() { EmpID = 9, Name = "Gerladio" };

Jones.AddSubordinate(Cesar);
Jones.AddSubordinate(Igor);
Jones.AddSubordinate(Gisnando);
Jones.AddSubordinate(Gerlandio);

Console.WriteLine($"EmpID={Thiago.EmpID}, Name={Thiago.Name}");

foreach (Employee manager in Thiago)
{
    Console.WriteLine($"\n EmpID={manager.EmpID}, Name={manager.Name}");
    foreach (var employee in manager)
        Console.WriteLine($" \t EmpID={employee.EmpID}, Name={employee.Name}");
}

Console.ReadKey();

