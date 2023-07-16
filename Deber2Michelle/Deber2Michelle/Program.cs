// See https://aka.ms/new-console-template for more information
using Deber2Michelle;

Console.WriteLine("-------- DEBER 2 MICHELLE VACA --------");
// Instanciar clases Vehiculo, Automovil y Camioneta
Vehiculo v1 = new Vehiculo("Chevrolet", "Onix", 2021);
Automovil a1 = new Automovil("VW","Polo", 2019, 5);
Camioneta c1 = new Camioneta("Mazda", "BT50", 2020, 1.7f);
Console.WriteLine();

Console.WriteLine("-------- VEHICULO --------");
Console.WriteLine(v1.getInformation());
Console.WriteLine(v1.runAction());
Console.WriteLine();

Console.WriteLine("-------- AUTOMOVIL --------");
Console.WriteLine(a1.getInformation());
Console.WriteLine(a1.runAction());
Console.WriteLine();

Console.WriteLine("-------- CAMIONETA --------");
Console.WriteLine(c1.getInformation());
Console.WriteLine(c1.runAction());
