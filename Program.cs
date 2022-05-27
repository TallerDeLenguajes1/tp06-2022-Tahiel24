//Arreglo de clases
Empleado[] empleados = new Empleado[3];
//Llenar datos
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Empleado N°" + (i + 1));
    Console.WriteLine("Nombre: ");
    string nom = Console.ReadLine();
    Console.WriteLine("Apellido: ");
    string ape = Console.ReadLine();
    Console.WriteLine("Fecha de nacimiento: ");
    DateTime fechaNac = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine("Estado civil(C:Casado,S:Soltero,D:Divorciado,V:Viudo): ");
    char estC = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Genero(H:Hombre, M:Mujer, O:Otro): ");
    char gen = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Fecha de ingreso a la empresa: ");
    DateTime fechaIng = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine("Sueldo basico: ");
    double sueldo = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese su cargo: ");
    string trabajo = Console.ReadLine();
    empleados[i] = new Empleado(fechaNac, nom, ape, estC, gen, fechaIng, sueldo, trabajo);
    Console.WriteLine("\n---------------------------\n");
}
//Controlar quien esta mas cerca de jubilarse
int jub = 0, indice = 0;
double sal = 0;
for (int i = 0; i < 3; i++)
{
    if (i == 0)
    {
        jub = empleados[i].Jubilacion();
    }
    else
    {
        if (empleados[i].Jubilacion() < jub)
        {
            indice = i;
            jub = empleados[i].Jubilacion();
        }

    }
    sal += empleados[i].SalarioTotal(empleados[i].Antiguedad(), empleados[i].Trab);
}

//Salarios totales y mostrar datos solicitados

Console.WriteLine($"Gasto total en concepto de salarios: {sal}\n");
Console.WriteLine("--------------Empleado mas proximo a jubilarse:----------------");
Console.WriteLine("Nombre: " + empleados[indice].Nombre);
Console.WriteLine("Apellido: " + empleados[indice].Apellido1);
Console.WriteLine("Fecha de nacimiento: " + empleados[indice].FechaNacimiento1);
Console.WriteLine("Estado civil: " + empleados[indice].EstadoCivil);
Console.WriteLine("Genero: " + empleados[indice].Genero);
Console.WriteLine("Fecha de ingreso a la empresa: " + empleados[indice].FechaIngreso);
Console.WriteLine("Sueldo basico: " + empleados[indice].SueldoBasico);
Console.WriteLine("Sueldo total: " + empleados[indice].SalarioTotal(empleados[indice].Antiguedad(), empleados[indice].Trab));
Console.WriteLine("Cargo: " + empleados[indice].Trab);
Console.WriteLine("Antiguedad: " + empleados[indice].Antiguedad());
Console.WriteLine("Edad del empleado: " + empleados[indice].Edad());
Console.WriteLine("Cantidad de años que le falta al trabajador para jubilarse: " + empleados[indice].EdadJub(empleados[indice].Edad()));
