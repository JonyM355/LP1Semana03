using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            //criar os jogadores
            //converter as strings em GameItem
            GameItem p1 = Enum.Parse<GameItem>(args[0]);
            GameItem p2 = Enum.Parse<GameItem>(args[1]);

            //verificar o resultado
            //convertê-lo para GameStatus
            GameStatus result = RockPaperScissors(p1, p2);

            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }


        //Método tipo GameStatus
        //2 parâmetros tipo GameItem
        private static GameStatus RockPaperScissors
            (GameItem player1, GameItem player2)
        {
            //Criar uma variável tipo Game Status
            GameStatus result;

            if (player1 == player2)
            {
                result = GameStatus.Draw;// Draw
            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors))
                ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper))
                ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                result = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                result = GameStatus.Player2Wins; // Player 2 wins
            }

            return result;
        }
    }
}
