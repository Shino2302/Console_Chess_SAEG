using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess_SAEG.Moves
{
    public class GamePieces
    {
        public string? PieceName { get; set;}
        public int PiecePositionRow { get; set; }
        public int PiecePositionColumn { get; set; }
    }
    public class King : GamePieces
    {
        public King()
        {
            PieceName = "KG";
            PiecePositionColumn = 4;
            PiecePositionRow = 7;
        }
        public void KingMove()
        {

        }
        public void KingAtack()
        {

        }
    }
    public class Queen : GamePieces
    {
        public Queen()
        {
            PieceName = "QN";
            PiecePositionColumn = 3;
            PiecePositionRow = 7;
        }
        public void QueenMove()
        {

        }
        public void QueenAtack()
        {

        }
    }
    public class Bishop: GamePieces 
    {
        ToolsForUserExperiences tool = new ToolsForUserExperiences();
        public void BishopMove(int positionX, int positionY)
        {
            int aux1 = positionX % 2;
            int aux2 = positionY % 2;
            positionY--;
            if (positionX < 0 || positionY > 7)
            {
                Console.WriteLine("Intente con una posicion valida! ");
                Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                if (continueWithPiece == 's' || continueWithPiece == 'S')
                {
                    Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                    char positionX2 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ingresa la posición de 1 al 8:");
                    positionY = Convert.ToInt32(Console.ReadLine());
                    BishopMove(tool.ConvertLettersToNumbers(positionX2), positionY);
                }
                else
                {
                    Console.WriteLine("¿Con que pieza quiere continuar? ");
                }
            }
            else if (aux1 == 0 && aux2 != 0)
            {
                PiecePositionColumn = positionX;
                PiecePositionRow = positionY;
            }
            else if(aux1 != 0 && aux2 == 0)
            {
                PiecePositionColumn = positionX;
                PiecePositionRow = positionY;
            }
            else
            {
                Console.WriteLine("Error!");
                Console.WriteLine("Intente con una posicion valida! ");
                Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                if (continueWithPiece == 's' || continueWithPiece == 'S')
                {
                    Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                    char positionX2 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ingresa la posición de 1 al 8:");
                    positionY = Convert.ToInt32(Console.ReadLine());
                    BishopMove(tool.ConvertLettersToNumbers(positionX2), positionY);
                }
                else
                {
                    Console.WriteLine("¿Con que pieza quiere continuar? ");
                }
            }
        }
        public void BishopAtack()
        {

        }
    }
    public class Knight : GamePieces
    {
        public void KnightMove(int positionX, int positionY)
        {
            ToolsForUserExperiences tool = new ToolsForUserExperiences();
            positionY--;
            if (positionX < 0 || positionY > 7)
            {
                Console.WriteLine("Intente con una posicion valida! ");
                Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                if (continueWithPiece == 's' || continueWithPiece == 'S')
                {
                    Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                    char positionX2 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ingresa la posición de 1 al 8:");
                    positionY = Convert.ToInt32(Console.ReadLine());
                    KnightMove(tool.ConvertLettersToNumbers(positionX2), positionY);
                }
                else
                {
                    Console.WriteLine("¿Con que pieza quiere continuar? ");
                }
            }
            else if(positionX == PiecePositionColumn + 2 || positionX == PiecePositionColumn - 2)
            {
                if(positionY == PiecePositionRow + 1 || positionY == PiecePositionRow - 1)
                {
                    PiecePositionColumn = positionX;
                    PiecePositionRow = positionY;
                }
                else
                {
                    Console.WriteLine("Error!");
                    Console.WriteLine("Intente con una posicion valida! ");
                    Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                    char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                    if (continueWithPiece == 's' || continueWithPiece == 'S')
                    {
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        char positionX2 = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        KnightMove(tool.ConvertLettersToNumbers(positionX2), positionY);
                    }
                    else
                    {
                        Console.WriteLine("¿Con que pieza quiere continuar? ");
                    }
                }
            }
            else if( positionX == PiecePositionColumn + 1 || positionX == PiecePositionColumn - 1)
            {
                if (positionY == PiecePositionRow + 2 || positionY == PiecePositionRow - 2)
                {
                    PiecePositionColumn = positionX;
                    PiecePositionRow = positionY;
                }
                else
                {
                    Console.WriteLine("Error!");
                    Console.WriteLine("Intente con una posicion valida! ");
                    Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                    char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                    if (continueWithPiece == 's' || continueWithPiece == 'S')
                    {
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        char positionX2 = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        KnightMove(tool.ConvertLettersToNumbers(positionX2), positionY);
                    }
                    else
                    {
                        Console.WriteLine("¿Con que pieza quiere continuar? ");
                    }
                }
            }
        }
        public void KnightAtack()
        {

        }
    }
    public class Rook : GamePieces
    {
        public void RookMove()
        {

        }
        public void RookAtack()
        {

        }
    }
    public class Pawns : GamePieces
    {
        ToolsForUserExperiences tool = new ToolsForUserExperiences();
        public bool FirstPawnMove { get; set; }
        public Pawns()
        {
            PiecePositionRow = 6;
            FirstPawnMove = false;
        }
        public void PawnMove(int positionX, int positionY, bool firstMov)
        {
            positionY--;
            if (positionX < 0 || positionY > 7)
            {
                Console.WriteLine("Intente con una posicion valida! ");
                Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                if (continueWithPiece == 's' || continueWithPiece == 'S')
                {
                    Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                    char positionX2 = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Ingresa la posición de 1 al 8:");
                    positionY = Convert.ToInt32(Console.ReadLine());
                    PawnMove(tool.ConvertLettersToNumbers(positionX2), positionY, FirstPawnMove);
                }
                else
                {
                    Console.WriteLine("¿Con que pieza quiere continuar? ");
                }
            }
            else if(PiecePositionRow == 0)
            {
                Console.WriteLine("En que deseas convertirlo: ");
                Console.WriteLine("1. En una reyna");
                Console.WriteLine("2. En un caballo");
                Console.WriteLine("3. En una torre");
                Console.WriteLine("4. En un alfil");
                int optionToChange = Convert.ToInt32(Console.ReadLine());
                switch (optionToChange)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
            else if(positionX != PiecePositionColumn)
            {
                Console.WriteLine("Intente con una posicion valida! ");
                Console.WriteLine("Quiere continuar con esta pieza? s para continua o lo que sea para cambiar de pieza");
                char? continueWithPiece = Convert.ToChar(Console.ReadLine());
                if (continueWithPiece == 's' || continueWithPiece == 'S')
                {
                    Console.WriteLine("Ingrese la posicion en X para el peón: ");
                    positionX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la posicion en Y para el peón: ");
                    positionY = Convert.ToInt32(Console.ReadLine());
                    PawnMove(positionX, positionY, firstMov);
                }
                else
                {
                    Console.WriteLine("¿Con que pieza quiere continuar? ");
                }
            }
            else if (firstMov == false && PiecePositionRow - positionY == 2)
            {
                PiecePositionRow = positionY;
                FirstPawnMove = true;
            }
            else
            {
                PiecePositionRow--;
                FirstPawnMove = true;
            }
        }
        public void PawnAtack()
        {

        }
    }
}
