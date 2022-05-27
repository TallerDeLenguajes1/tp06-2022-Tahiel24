public class Empleado{
    //Declaracion de variables
    private string nombre;
    private string Apellido;
    private DateTime FechaNacimiento;
    private char estadoCivil;
    private char genero;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private string trab;
    public enum Cargo{Auxiliar,Administrativo, Ingeniero, Especialista, Investigador}

    //Propiedades
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime FechaNacimiento1 { get => FechaNacimiento; set => FechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public string Trab { get => trab; set => trab = value; }

    //Constructor
    public Empleado(DateTime fecha,string name, string ape,char est,char gen,DateTime fechaIng,double sueldoB,string trabajo)
    {
        FechaNacimiento1=fecha;
        Apellido1=ape;
        Nombre=name;
        EstadoCivil=est;
        Genero=gen;
        FechaIngreso=fechaIng;
        SueldoBasico=sueldoB;
        Trab=trabajo;
    }

    //Funciones
    public int Antiguedad(){
        DateTime fecha;
        int ao,actual,resultado;
        fecha=fechaIngreso;
        ao=Convert.ToInt32(fecha.Year);
        actual=Convert.ToInt32(DateTime.Now.Year);
        resultado=actual-ao;
        return resultado;
    }

    public int Edad(){
        DateTime fecha;
        int ao,actual,resultado;
        fecha=FechaNacimiento;
        ao=Convert.ToInt32(fecha.Year);
        actual=Convert.ToInt32(DateTime.Now.Year);
        resultado=actual-ao;
        return resultado;
    }

    public int EdadJub(int edadAcT){
    int JubH=65,JubM=60,resta=0;
        switch(genero){
            case 'H':
                resta=JubH-edadAcT;
                break;
            case 'M':
                resta=JubM-edadAcT;
                break;
        }
        return resta;
    }
    
    public double SalarioTotal(int ant,string cargoEl){
        double adicional=0,total,aux1,aux2;
        int porcentaje,porcentaje2;
        //Adicional para Antiguedad
        if(ant<20){
            porcentaje=ant;
            aux1=(sueldoBasico*porcentaje)/100;
            adicional+=aux1;
        }else{
            porcentaje=25;
            aux1=(sueldoBasico*porcentaje)/100;
            adicional+=aux1;
        }
        //Adicional segun cargo
        switch(cargoEl){
            case "Ingeniero":
                porcentaje2=50;
                aux2=(adicional*porcentaje2)/100;
                adicional+=aux2;
                break;
            case "Especialista":
                porcentaje2=50;
                aux2=(adicional*porcentaje2)/100;
                adicional+=aux2;
                break;
        }
        //Adicional segun estado civil
        if(estadoCivil=='C'){
            adicional+=15000;
        }
        //Monto total
        total=sueldoBasico+adicional;
        return total;
        
    }
    public int Jubilacion(){
        if(genero=='H') {
            return 65-Edad();
        }else{
            return 60-Edad();
        }
    }
}




  


    

