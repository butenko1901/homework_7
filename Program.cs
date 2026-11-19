using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    Console.WriteLine("\n=== Шаблони проєктування (Домашня робота) ===");
    Console.WriteLine("1. Завдання 1 — Abstract Factory (Mercedes)");
    Console.WriteLine("2. Завдання 2 — Builder (MargaritaPizzaBuilder)");
    Console.WriteLine("3. Завдання 3 — Mediator (ConcreteColleague3)");
    Console.WriteLine("4. Завдання 4 — Decorator (Ялинка)");
    Console.WriteLine("5. Завдання 5 — Prototype (Трикутник)");
    Console.WriteLine("6. Завдання 6.1 — Factory Method (ExcelDocument)");
    Console.WriteLine("7. Завдання 6.2 — Adapter (Розетка)");
    Console.WriteLine("0. Вихід");
    Console.Write("Оберіть номер завдання: ");

    string? choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            AbstractFactory.AbstractFactoryTask.Run();
            break;
        case "2":
            Builder.BuilderTask.Run();
            break;
        case "3":
            Mediator.Examples.MediatorTask.Run();
            break;
        case "4":
            DecoratorTree.DecoratorTask.Run();
            break;
        case "5":
            PrototypeFigure.PrototypeTask.Run();
            break;
        case "6":
            FactoryMethodExample.FactoryMethodTask.Run();
            break;
        case "7":
            AdapterExample.AdapterTask.Run();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
            break;
    }
}