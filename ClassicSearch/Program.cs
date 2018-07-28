using System;

namespace ClassicSearch
{
    class Program
    {
        // Generate a random number between two numbers  
        public static int RandomNumber(int min, int max)  
        {  
            Random random = new Random();  
            return random.Next(min, max);  
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Database Size : 256\n");
            int x=0;
            int i;
            int[] array = new int[256];
            for(i=0;i<256;i++)
            {
                array[i]=i;

            }

            //Reshuffling the array

            for(i=0;i<1000;i++)
            {
                
                int a = RandomNumber(0,255);
                int b = RandomNumber(0,255);
                int  c;
                c = array[a];
                array[a] = array[b];
                array[b] = c;

            }
            Console.Write("Created the list and Randomized it\n\n");
            
            
            Console.Write("Enter the search number < 256:");
            try 
            {
                x = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("No input provided. Assigning a Random Number");
                
                x = RandomNumber(0,255);
            }

            
            Console.Write("Applying he classical Search... Press a key to start ");
            Console.ReadLine();
            // Find the required number from star

            for(i=0;i<256;i++)
            {

                if (array[i]==x)
                {
                    Console.Write("\n\n\nFinally Found the Value in " +i+ "th iteration\n\n");
                    break;
                }
                else
                {
                    Console.Write("\nFound "+ Convert.ToString(array[i])+" .. Skipping ...");
                }

            }

        }
        
    }
}
