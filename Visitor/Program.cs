using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo los elementos
            Guerrero g1 = new Guerrero();
            Guerrero g2 = new Guerrero();
            Mago m1 = new Mago();
            Mago m2 = new Mago();

            //Creo lista para guardar los elementos
            List<IPersonaje> personajes = new List<IPersonaje>();

            //Agrego los elementos a una lista
            personajes.Add(g1);
            personajes.Add(g2);
            personajes.Add(m1);
            personajes.Add(m2);

            //Creamos el visitor y le pasamos la lista
            IVisitor visitorArma = new EquiparArma();
            visitorArma.visit(personajes);

            Console.WriteLine("Arma del guerrero uno: " + g1.getArma());
            Console.WriteLine("Arma del guerrero dos: " + g1.getArma());
            Console.WriteLine("Arma del mago uno: " + m1.getArma());
            Console.WriteLine("Arma del mago dos: " + m2.getArma());

            Console.ReadKey();
        }
    }
}
