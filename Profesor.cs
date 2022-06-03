using System;
namespace PracticExa
{
class Profesor
{
    public string nombre{set; get;}
    public string apellido{set; get;}
    public string direccion{set; get;} 
    public int cedula{set;get;}

    public Profesor(string nombre,string apellido,string direccion,int cedula)
    {
        this.nombre=nombre;
        this.apellido=apellido;
        this.direccion=direccion;
        this.cedula=cedula;
    }
    public void Imprimir()
    {
        Console.WriteLine("Nombre Profesor: " +nombre + "\n Apellido: " + apellido+ "\n direccion: "+direccion+ "\n cedula: " + cedula);

    }

    public void registrar()
    {
        Console.WriteLine("Profesor:" +nombre+ " " +apellido+ " " +direccion+ " " +cedula);
    }
}
}