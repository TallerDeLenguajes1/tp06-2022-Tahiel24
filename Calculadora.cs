public class Calculadora
{
    private double resultado;

    //Get y set
    public double Resultado { get => resultado; set => resultado = value; }

    //Constructora
    public Calculadora(double termino){
        resultado=termino;
    }

    //Operaciones
    public void Sumar(double termino){
        resultado+=termino;
    }

    public void Restar(double termino){
        resultado-=termino;
    }

    public void Multiplicar(double termino){
        resultado*=termino;
    }

    public void Dividir(double termino){
        resultado/=termino;
    }

    public void Limpiar(){
        resultado=10;
    }
}
