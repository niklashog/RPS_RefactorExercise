namespace RPS
{
    internal class Program
    {
        /// <summary>
        /// 
        /// Titta på denna video. Gör sedan samma refactoring.
        /// https://www.youtube.com/watch?v=cCSrPZroICg
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            GameManager gm = new GameManager();

            do
            {
                RoundResult result = gm.PlayRound();
                if (result == RoundResult.Player1Win)
                {
                    Console.WriteLine("Player 1 Wins!");
                }
                else if (result == RoundResult.Player2Win)
                {
                    Console.WriteLine("Player 2 Wins!");
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                }
                Console.Write("Play Again (Y/N)? ");
            } while (Console.ReadLine().ToUpper() == "Y");
        }
    }
}
