using System;

namespace Methods
{
   public class Methods
    {

        static void Main()
        {

            Nothing();//any parameter and any return value

            int randomValue = comeback();
                Console.WriteLine($"Random value returned: {randomValue}");// take it the random paramter 1-121 and retrun the divide by 2

                
            
           int vall= multiply(12,34);//call the muliply method which the take it parameter and return the value

            Console.WriteLine($"Return : {vall}");// write the retun multiply

            namesurnme("Serhat", "Aker"); // call the does not return value but take the parameters
        }

        private static void namesurnme(object serhat, object aker)
        {
            throw new NotImplementedException();
        }

        static void Nothing()// it is not tae parameter and doesnt any return
            {
                Console.WriteLine("i cant take back my word *Bulutsuzluk Özlemi*");

            }


        static int comeback()// it is process the random value
        {
            Random r = new Random();
           int cmbck=r.Next(1,120);
            int back = cmbck % 2;
            return back;
            
        }

        static int multiply(int i,int j)// Muliply fuction
        {
            int Value=i*j;

            return Value;

        }
        static void namesurnme(string name,string surname)// take it the parameter but doesnt the return value
        {
            Console.WriteLine( $"Welcome {name} {surname}");

        }
    } 
    
}