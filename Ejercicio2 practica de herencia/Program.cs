using System;

namespace Ejercicio2_practica_de_herencia
{
    
    class Contacto
    {
        private string nombre;
        private string apellidos;
        private double telefono;
        private string direccion;

        public void setContacto(string nombre, string apellidos, double telefono, string direccion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.direccion = direccion;
        }

        public void Saludar()
        {
            string saludo = "Hola soy " + nombre + " " + apellidos + " mi telefono es " + telefono + " y mi dirección es " + 
                direccion + "\n";
            Console.WriteLine(saludo);
        }
    }

    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.setContacto("Miguelina","Lorenzo",2038762486,"N/A");
            contacto1.Saludar();

            Contacto contacto2 = new Contacto();
            contacto2.setContacto("Marie", "Rose", 8093393456, "N/A");
            contacto2.Saludar();

            Console.WriteLine(contacto1);
            Console.WriteLine(contacto2);
        }
    }

}
