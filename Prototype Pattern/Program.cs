using Prototype_Pattern;

Employee emp1 = new Employee { Name = "samir", Skills = ["c#", ".Net"] };
Employee emp2 = emp1;
emp2.Name = "Rahim";
Console.WriteLine(emp1.Name);