
Console.WriteLine("Ingrese un numero: ");
double numero = Convert.ToDouble(Console.ReadLine());
Calculadora nuevaCalc = new Calculadora(numero);
Console.WriteLine("\nSeleccione una operacion: ");
Console.WriteLine("\n1. Suma");
Console.WriteLine("\n2. Resta");
Console.WriteLine("\n3. Producto");
Console.WriteLine("\n4. Cociente");
Console.WriteLine("\n5. Limpiar");
Console.WriteLine("\n6. Salir");
int op = Convert.ToInt32(Console.ReadLine());

while (op != 6)
{
    switch (op)
    {
        case 1:
            Console.WriteLine("Numero que desea sumar: ");
            nuevaCalc.Sumar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Resultado: " + nuevaCalc.Resultado);
            break;
        case 2:
            Console.WriteLine("Numero que desea restar: ");
            nuevaCalc.Sumar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Resultado: " + nuevaCalc.Resultado);
            break;
        case 3:
            Console.WriteLine("Numero que desea multiplicar: ");
            nuevaCalc.Sumar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Resultado: " + nuevaCalc.Resultado);
            break;
        case 4:
            Console.WriteLine("Numero que desea dividir: ");
            nuevaCalc.Sumar(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Resultado: " + nuevaCalc.Resultado);
            break;
        case 5:
            nuevaCalc.Limpiar();
            Console.WriteLine("Limpiado");
            break;
        case 6:
            Console.WriteLine("Saliendo del programa");
            break;
    }
   
    Console.WriteLine("\nIngrese un numero del menu para seguir operando: ");
    op = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nPrograma finalizado");

