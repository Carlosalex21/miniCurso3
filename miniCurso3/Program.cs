// See https://aka.ms/new-console-template for more information
using System.Xml;

//clases y herencias

auto objauto = new auto("Toyota","supra","azul","ABC-123");
objauto.acelerar(100);
objauto.girar(30);
objauto.frenar(20);

Console.WriteLine("El nombre de mi auto es: {0}, el modelo {1}, el color {2} y la placa {3}",objauto.marca, objauto.modelo, objauto.color, objauto.placa);

trabajador objtrabajador = new trabajador("Juan", "Perez", "29897144", 12345);

Console.WriteLine("Datos del trabajador "+$"nombre: {objtrabajador.Nombre}" + $" apellido: {objtrabajador.Apellido}"+ $" Cedula: {objtrabajador.cedula}"+$" Sueldo: {objtrabajador.sueldo}");
Console.Read();

public class auto
{
    private double velocidad = 0;
    public string marca {get; set;}
    public string modelo { get; set; }
    public string color { get; set; }
    public string placa { get; set; }   
    public double Velocidad { get => velocidad; set => velocidad = value; }

    public auto()
    {
        
    }
    public auto(string marca,string modelo, string color,string placa)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.color = color;
        this.placa = placa;
    }

    public void acelerar(double cantidad)
    {
        Console.WriteLine("Accionando el mecanismo de aceleracion por defecto");
        Console.WriteLine("Incrementando la velocidad en {0} km/h",cantidad);
        this.velocidad += cantidad;
    }
    public void girar(double cantidad)
    {
        Console.WriteLine("Girando el auto {0} grados",cantidad);
    }
    public void frenar(double cantidad)
    {
        Console.WriteLine("Reduciendo la velocidad en {0} km",cantidad);
        this.velocidad -= cantidad;
    }
}

public class persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string cedula { get; set; }
    public int edad { get; set; }

    public persona(string nombre, string apellido, string cedula)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.cedula = cedula;
    }

    public void cumpleaños()
    {
        edad++;
    }
}

public class trabajador:persona
{
    public int sueldo;

    public trabajador(string nombre, string apellido, string cedula, int sueldo)
         :base(nombre,apellido, cedula)   
    {
        this.sueldo = sueldo;
    }
}
