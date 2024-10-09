namespace homework_2_methods_and_peer_work
{
    internal class Program
    {

        //Partner A Function
        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;   
        }
        static void Main(string[] args)
        {
            //Partner A: Yuri
            //Partner B: Nick

            //Yuri should fix all the comments later :P check the rubric
            //Variables
            int sum;
            int result;
            int nickFavoriteNumber;
            int yuriFavoriteNumber;



            //Initialize
            sum = 0;
            result = 0;
            nickFavoriteNumber = 37;
            yuriFavoriteNumber = 16;



            //Partner B function
            int Subtract(int num1, int num2)
            {
                int answer = 0;
                answer = num1 - num2;

                return answer;
            }

            //Start of the actual program
            Console.WriteLine("Nick's favorite number is : " + nickFavoriteNumber);
            Console.WriteLine("Yuri's favorite number is : " + yuriFavoriteNumber);

            //Console.WriteLine("About to call Partner B's subtract method.");
            //Console.WriteLine("When we subtract " + yuriFavoriteNumber + " from " + nickFavoriteNumber + " we get : " + result);
            //Console.WriteLine("When we subtract " + 3 + " from " + nickFavoriteNumber + " we get : " + result);

            sum = Add(nickFavoriteNumber, yuriFavoriteNumber);
            result = Subtract(yuriFavoriteNumber, nickFavoriteNumber);

            Console.WriteLine("When we add our favorite numberes together we get: " + sum);
            Console.WriteLine("When we subtract our favorite numbers from each other we get: " + result);
            

        }

    }
}
