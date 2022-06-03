// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace PracticExa
{
    class Program
    {
        public static void Main (string []args)
        {
         profesorH profesor1=new profesorH(10,20,"MARIO","BROS","CASTILLO 64",987654321);
         profesor1.Imprimir();
         profesor1.Calcular();
         
         profesorN profesor2=new profesorN("Luiggi", "Bross", "Castillo 65", 123456747);
         profesor2.Imprimir();
         profesor2.Calcular();

        profesorC profesor3=new profesorC("NUMERO","18","KAME HOUSE",1818181818);
        profesor3.Imprimir();
        profesor3.Calcular();

        Profesor obj1=new Profesor("MARIO","BROS","CASTILLO64",987654321);
        Profesor obj2=new Profesor("Luiggi","Bross","Castillo 65",123456789);
        Profesor obj3=new Profesor("NUMERO","18","KAME HOUSE",18181818);

        List<Profesor> listaprofesores=new List<Profesor>();
        listaprofesores.Add(obj1);
        listaprofesores.Add(obj2);
        listaprofesores.Add(obj3);
        
        foreach(Profesor item in listaprofesores)
        {
            item.registrar();
        }
        }
    }
}
