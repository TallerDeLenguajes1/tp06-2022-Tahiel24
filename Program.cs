﻿Console.WriteLine("----------------Primer empleado---------------");
Console.WriteLine("Nombre: ");
string nom=Console.ReadLine();
Console.WriteLine("Apellido: ");
string ape=Console.ReadLine();
Console.WriteLine("Fecha de nacimiento: ");
DateTime fechaNac= Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Estado civil(C:Casado,S:Soltero,D:Divorciado,V:Viudo): ");
char estC=Convert.ToChar(Console.ReadLine());
Console.WriteLine("Genero(H:Hombre, M:Mujer, O:Otro): ");
char gen=Convert.ToChar(Console.ReadLine());
Console.WriteLine("Fecha de ingreso a la empresa: ");
DateTime fechaIng=Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Sueldo basico: ");
double sueldo=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese su cargo: 0 = (Auxliar ) / 1  = (Administrativo) // 2 = (Ingeniero) // 3 = (Especialista) // 4 = (Investigador) ");