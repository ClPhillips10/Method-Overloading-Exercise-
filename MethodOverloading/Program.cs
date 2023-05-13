namespace MethodOverloading
{
    public class Program
    {
        //Add 1 and 2 method----------------------------
        public static int Add(int num1, int num2)

        {

            return num1 + num2;

        }

        //Decimal method----------------------------------
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;

        }

        //
        // BOOL METHOD-------------------------------------
        public static string Add(int num1, int num2, bool HasMoney)

        {

            string Add = "";
            int Answer = num1 + num2;
            //if Bool is true
            if (HasMoney == true && Answer == 1)
            {
                return $"{Answer} dollar.";

            }
            else if (HasMoney == true && Answer > 1)
            {
                return $"{Answer} dollars.";
            }   
                
                
              
            else if (HasMoney == true && Answer < 1)
            {
                return $"{Answer}";
            }
            

            // if bool is false
            else
            {
                return Answer.ToString();
            }

        }


        // main method--------------------------------
        static void Main(string[] args)
        {


            
            Console.Write("Enter the ammount of cash you have: ");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("How much in your bank?");
            var num2 = int.Parse(Console.ReadLine());

            


            if (num1 + num2 > 0)
            {
                bool HasMoney = true;
         
                Console.WriteLine(Add(num1, num2, HasMoney));
            }
            else
            {
                bool HasMoney = false;
                Console.WriteLine("You're Broke");
            }

            




            Console.ReadLine();



            

        }

        
    }

    
}
