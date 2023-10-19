using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
 
namespace Menu_inventario
{
    class Program
    {
        static void Main(string[] args)
        {             
            bool salir = false;
            Journal _userJounal = new Journal();            
 
            while (!salir) {
 
                try
                {
                     
                    Console.WriteLine("-------------WELCOME------------------");

                    Console.WriteLine("PLEASED SELECT ONE OF THE FOLLOWING CHOICES");
                    Console.WriteLine("1.WRITE");
                    Console.WriteLine("2.DISPLAY");
                    Console.WriteLine("3.LOAD");
                    Console.WriteLine("4.SAVE");
                    Console.WriteLine("5.QUIT");
                    Console.Write("WHAT WOULD YOU LIKE TO DO?: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());

 
                    switch (opcion)
                    {
                        case 1:                            
                            _userJounal.WriteJournal();                            
                            break;
 
                        case 2:                            
                            _userJounal.DisplayJounal();                      
                            break;
 
                        case 3:
                            _userJounal.LoadJournal();
                            break;
                        case 4:
                            _userJounal.SaveJournal();

                            break;

                        case 5:
                            Console.Write("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opcion incorrecta, ingrese una opcion valida");
                            break;
                    }
 
                }
                catch (FormatException )
                {
                 
                }
            }              
        }
    }
}