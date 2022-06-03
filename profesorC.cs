using System;
namespace PracticExa
{
    class profesorC:Profesor
    {
        public int sueldobasico{set;get;}
        public int horasextras{set;get;}

        public profesorC(string nombre,string apellido,string direccion,int cedula):base(nombre,apellido,direccion,cedula)
        {
            this.sueldobasico=sueldobasico;
            this.horasextras=horasextras;
        }

        public void Calcular()
        {
            int sueld,precioh,total;
            Console.WriteLine("INGRESE EL NÚMERO DE LAS HORAS EXTRAS");
            horasextras=int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL PRECIO DE LAS HORAS EXTRAS");
            precioh=int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL SUELDO BASICO");
            sueldobasico=int.Parse(Console.ReadLine());
            sueld=horasextras*precioh;
            total=sueldobasico+sueld;
            Console.WriteLine("SUELDO TOTAL ES: " +total);
        }
    }
}