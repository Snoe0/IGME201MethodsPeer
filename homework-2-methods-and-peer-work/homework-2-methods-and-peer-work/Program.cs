namespace homework_2_methods_and_peer_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Partner A: Yuri
            //Partner B: Nick

            //Yuri should fix all the comments later :P check the rubric
            int result;
            int nickFavoriteNumber;
            


            //Initialize
            result = 0;
            nickFavoriteNumber = 37;


            //Partner B function
            int Subtract(int num1, int num2)
            {
                int answer = 0;
                answer = num1 - num2;

                return answer;
            }

            //Start of the actual program
            Console.WriteLine("Nick's favorite number is : " + nickFavoriteNumber);

            //Console.WriteLine("About to call Partner B's subtract method.");
            //Console.WriteLine("When we subtract " + yuriFavoriteNumber + " from " + nickFavoriteNumber + " we get : " + result);
            //Console.WriteLine("When we subtract " + 3 + " from " + nickFavoriteNumber + " we get : " + result);

            result = Subtract(3, nickFavoriteNumber);

            Console.WriteLine("When we subtract our favorite numbers from each other we get: " + result);

        }
    }
}
