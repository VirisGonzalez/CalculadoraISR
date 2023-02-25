using System;
using TecNM.Practica3_0.Core.Entities;
using TecNM.Practica3_0.Core.Managers;
using TecNM.Practica3_0.Core.Services;


namespace TecNM.Practica31.App;

public static class Program{
    public static void Main(string[] args){
        float salario = 0;
        
        System.Console.WriteLine("Ingrese su salario anual: ");
        Single.TryParse(System.Console.ReadLine(), out salario);
        //decimal salario = decimal.Parse(Console.ReadLine());

        var person = new Person{Salario = salario};

        var service = new ISRService();
        var manager = new ISRManager(service);

        ISR isr = manager.GetIsr(person);

        System.Console.WriteLine($"Su ISR anual es: {isr.TotalIsr}");
    }
}