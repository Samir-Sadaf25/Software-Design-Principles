using Prototype_Pattern;

Employee emp1 = new Employee { Name = "samir", Skills = ["c#", ".Net"] };
Employee emp2 = emp1.Clone();
emp2.Name = "rahim";
emp2.Skills = ["Angular", "Express"];
Console.WriteLine(emp1.Name);
foreach(var obj in emp2.Skills)
{
    Console.WriteLine(obj);
}
Console.WriteLine();
foreach (var obj in emp1.Skills)
{
    Console.WriteLine(obj);
}