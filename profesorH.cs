using System;
namespace PracticExa
{
    class profesorH:Profesor
    {
        public int preciohora{set; get;}
        public int cantidadhora{set;get;}
        public profesorH(int preciohora,int cantidadhora,string nombre, string apellido, string direccion,int cedula): base(nombre, apellido,direccion,cedula)
        {
            this.preciohora=preciohora;
            this.cantidadhora=cantidadhora; 
        }
        public void Calcular()
        {
            int sueldo1;
            sueldo1=preciohora*cantidadhora;

            Console.WriteLine("El sueldo es: " +sueldo1);
        }

}
}

