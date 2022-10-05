using IntroEntityFramework.Models;

SystemContext context = new SystemContext();
//Trabalhar com migrations depois
context.Database.EnsureCreated();

// Computer c1 = new Computer(1, "2GB", "i3");
// context.Computers.Add(c1);
// context.SaveChanges();

// Computer c2 = new Computer(2, "4GB", "i5");
// context.Computers.Add(c2);
// context.SaveChanges();

// Computer c3 = new Computer(3, "6GB", "i100000");
// context.Computers.Add(c3);
// context.SaveChanges();


IEnumerable<Computer> computers = context.Computers.ToList();
foreach (var computer in computers)
{
    Console.WriteLine($"{computer.Id}, {computer.Ram}, {computer.Processor}");
}

Computer encontrado = context.Computers.Find(2);
Console.WriteLine($"{encontrado.Id}, {encontrado.Ram}, {encontrado.Processor}");

encontrado.Ram = "4000000000000000000bg";
encontrado.Processor = "ryzen 5 amd";
context.Computers.Update(encontrado);
context.SaveChanges();

context.Computers.Remove(encontrado);
context.SaveChanges();