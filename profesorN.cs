using System;
namespace PracticExa
{
    class profesorN:Profesor
    {
        public int sueldofijo{set;get;}

        public profesorN(string nombre,string apellido,string direccion,int cedula):base(nombre,apellido,direccion,cedula)
        {
            this.sueldofijo=sueldofijo;
        }

        public void Calcular()
        {
            do
            {
                Console.WriteLine("INGRESE EL SUELDO MAYOR A 1000");
                sueldofijo=int.Parse(Console.ReadLine());

            }while(sueldofijo < 1000);
            Console.WriteLine("El sueldo es de: " + sueldofijo);
        }
    }
}