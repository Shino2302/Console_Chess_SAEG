using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Chess_SAEG.Moves;

namespace Console_Chess_SAEG.TableGame
{
    public class TableGames
    {
        ToolsForUserExperiences tool = new ToolsForUserExperiences();
        string?[,] logicTableGame = new string?[8, 8];
        char positionX = 'A';
        int positionY = 0;
        int auxPositions = 0;
        public void OnTableGame()
        { 
            bool lineFinish = false;
            for (int i = 0; i < 8; i++)
            {   
                if(i == 0)
                {
                    Console.Write("+--");
                }
                else if (i > 0)
                {
                    Console.WriteLine();
                    Console.Write("+--");
                }
                for (int j = 0; j < 7; j++)
                {
                    if (j == 6)
                    {
                        Console.Write("+--+");
                        lineFinish = true;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("+--");
                    }
                }
                if(lineFinish == true)
                {
                    Console.Write($"|{logicTableGame[i,0]}");
                    for (int j = 0; j < 7; j++)
                    {
                        if (j == 6)
                        {
                            Console.Write($"|{logicTableGame[i,j+1]}| {i+1}");
                            lineFinish = false;
                        }
                        else
                        {
                            Console.Write($"|{logicTableGame[i, j+1]}");
                        }
                    }
                }
                if(i == 7)
                {
                    Console.WriteLine();
                    Console.Write("+--");
                    for (int j = 0; j < 7; j++)
                    {
                        if (j == 6)
                        {
                            Console.Write("+--+");
                        }
                        else
                        {
                            Console.Write("+--");
                        }
                    }
                    Console.WriteLine();
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write($" {tool.ForTheTableGame(j)} ");
                    }
                }
            }
        }
        public void GameActivity()
        {
            King kn = new King();
            Queen qn = new Queen();
            
            Bishop b1 = new Bishop();
            b1.PieceName = "B1";
            b1.PiecePositionRow = 7;
            b1.PiecePositionColumn = 2; 

            Bishop b2 = new Bishop();
            b2.PieceName = "B2";
            b2.PiecePositionRow = 7;
            b2.PiecePositionColumn = 5;
            
            Knight h1 = new Knight();
            h1.PieceName = "H1";
            h1.PiecePositionRow = 7;
            h1.PiecePositionColumn = 1;

            Knight h2 = new Knight();
            h2.PieceName = "H2";
            h2.PiecePositionRow = 7;
            h2.PiecePositionColumn = 6;

            Rook t1 = new Rook();
            t1.PieceName = "T1";
            t1.PiecePositionRow = 7;
            t1.PiecePositionColumn = 0;

            Rook t2 = new Rook();
            t2.PieceName = "T2";
            t2.PiecePositionRow = 7;
            t2.PiecePositionColumn = 7;

            Pawns p1 = new Pawns();
            p1.PieceName = "P1";
            p1.PiecePositionColumn = 0;
            
            Pawns p2 = new Pawns();
            p2.PieceName = "P2";
            p2.PiecePositionColumn = 1;
            
            Pawns p3 = new Pawns();
            p3.PieceName = "P3";
            p3.PiecePositionColumn = 2;
            
            Pawns p4 = new Pawns();
            p4.PieceName = "P4";
            p4.PiecePositionColumn = 3;
            
            Pawns p5 = new Pawns();
            p5.PieceName = "P5";
            p5.PiecePositionColumn = 4;
            
            Pawns p6 = new Pawns();
            p6.PieceName = "P6";
            p6.PiecePositionColumn = 5;
            
            Pawns p7 = new Pawns();
            p7.PieceName = "P7";
            p7.PiecePositionColumn = 6;
            
            Pawns p8 = new Pawns();
            p8.PieceName = "P8";
            p8.PiecePositionColumn = 7;

            while (true)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if(kn.PiecePositionRow == i && kn.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = kn.PieceName;
                        }
                        else if (qn.PiecePositionRow == i && qn.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = qn.PieceName;
                        }
                        else if (b1.PiecePositionRow == i && b1.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = b1.PieceName;
                        }
                        else if (b2.PiecePositionRow == i && b2.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = b2.PieceName;
                        }
                        else if (h1.PiecePositionRow == i && h1.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = h1.PieceName;
                        }
                        else if (h2.PiecePositionRow == i && h2.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = h2.PieceName;
                        }
                        else if (t1.PiecePositionRow == i && t1.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = t1.PieceName;
                        }
                        else if (t2.PiecePositionRow == i && t2.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = t2.PieceName;
                        }
                        else if (p1.PiecePositionRow == i && p1.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p1.PieceName;
                        }
                        else if (p2.PiecePositionRow == i && p2.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p2.PieceName;
                        }
                        else if (p3.PiecePositionRow == i && p3.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p3.PieceName;
                        }
                        else if (p4.PiecePositionRow == i && p4.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p4.PieceName;
                        }
                        else if (p5.PiecePositionRow == i && p5.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p5.PieceName;
                        }
                        else if (p6.PiecePositionRow == i && p6.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p6.PieceName;
                        }
                        else if (p7.PiecePositionRow == i && p7.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p7.PieceName;
                        }
                        else if (p8.PiecePositionRow == i && p8.PiecePositionColumn == j)
                        {
                            logicTableGame[i, j] = p8.PieceName;
                        }
                        else
                        {
                            logicTableGame[i, j] = "  "; 
                        }
                    }
                }
                OnTableGame();
                Console.WriteLine();
                Console.WriteLine("Que pieza quieres utlilizar: ");
                Console.WriteLine("Escojela como aparecen en el tablero!");
                string selectPiece = Console.ReadLine();
                switch (selectPiece)
                {
                    case "KG":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "QN":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "B1":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        for(int i = 7; i >= auxPositions; i--)
                        {
                            for(int j = 0; j > positionY; j++)
                            {
                                if (positionX == b1.PiecePositionColumn && positionY == b1.PiecePositionRow)
                                {
                                    Console.WriteLine("Es la posicion actual, selecciona una valida");
                                    break;
                                }
                                else if (logicTableGame[i,j] != "  " && logicTableGame[i,j] != b1.PieceName)
                                {
                                    Console.WriteLine("No puedes realizar este movimineto");
                                    break;
                                }
                                else
                                {
                                    b1.BishopMove(auxPositions, positionY);
                                }
                            }
                        }
                        break;
                    case "B2":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        for (int i = b2.PiecePositionRow; i < auxPositions; i--)
                        {
                            for (int j = b1.PiecePositionColumn; j < positionY; j--)
                            {
                                if (positionX == b2.PiecePositionColumn && positionY == b2.PiecePositionRow)
                                {
                                    Console.WriteLine("Es la posicion actual, selecciona una valida");
                                    break;
                                }
                                else if (logicTableGame[i, j] != "  " && logicTableGame[i, j] != b2.PieceName)
                                {
                                    Console.WriteLine("No puedes realizar este movimineto");
                                    break;
                                }
                                else
                                {
                                    b2.BishopMove(auxPositions, positionY);
                                }
                            }
                        }
                        break;
                    case "H1":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        if (logicTableGame[positionY - 1, auxPositions] != "  ")
                        {
                            Console.WriteLine("No puedes hacer este movimiento, porque hay una pieza en esa posicion");
                        }
                        else
                        {
                            h1.KnightMove(auxPositions, positionY);
                        }
                        break;
                    case "H2":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        if(positionY < 0)
                        {
                            positionY = 0;
                            if (logicTableGame[positionY - 1, auxPositions] != "  ")
                            {
                                Console.WriteLine("No puedes realizar este movimiento");
                            }
                            else
                            {
                                h2.KnightMove(auxPositions, positionY);
                            }
                        }
                        else if(positionY > 7)
                        {
                            positionY = 7;
                            if (logicTableGame[positionY - 1, auxPositions] != "  ")
                            {
                                Console.WriteLine("No puedes realizar este movimiento");
                            }
                            else
                            {
                                h2.KnightMove(auxPositions, positionY);
                            }
                        }
                        else
                        {
                            if (logicTableGame[positionY - 1, auxPositions] != "  ")
                            {
                                Console.WriteLine("No puedes realizar este movimiento");
                            }
                            else
                            {
                                h2.KnightMove(auxPositions, positionY);
                            }
                        }
                        break;
                    case "T1":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        if (positionY < 0)
                        {
                            positionY = 0;
                            if (logicTableGame[positionY - 1, auxPositions] != "  ")
                            {
                                Console.WriteLine("No puedes realizar este movimiento");
                            }
                            else
                            {
                                h2.KnightMove(auxPositions, positionY);
                            }
                        }
                        else if (positionY > 7)
                        {
                            positionY = 7;
                            if (logicTableGame[positionY - 1, auxPositions] != "  ")
                            {
                                Console.WriteLine("No puedes realizar este movimiento");
                            }
                            else
                            {
                                h2.KnightMove(auxPositions, positionY);
                            }
                        }
                        break;
                    case "T2":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "P1":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions,positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p1.PawnMove(auxPositions,positionY,p1.FirstPawnMove);
                        }
                        break;
                    case "P2":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p2.PawnMove(auxPositions, positionY, p2.FirstPawnMove);
                        }
                        break;
                    case "P3":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p3.PawnMove(    auxPositions, positionY, p3.FirstPawnMove);
                        }
                        break;
                    case "P4":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p4.PawnMove(auxPositions, positionY, p4.FirstPawnMove);
                        }
                        break;
                    case "P5":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[ auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p5.PawnMove(auxPositions, positionY, p5.FirstPawnMove);
                        }
                        break;
                    case "P6":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p6.PawnMove(auxPositions, positionY, p6.FirstPawnMove);
                        }
                        break;
                    case "P7":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p7.PawnMove(auxPositions, positionY, p7.FirstPawnMove);
                        }
                        break;
                    case "P8":
                        Console.WriteLine("Igrengresa las posicion de la 'A' a la 'H'");
                        positionX = Convert.ToChar(Console.ReadLine());
                        auxPositions = tool.ConvertLettersToNumbers(positionX);
                        Console.WriteLine("Ingresa la posición de 1 al 8:");
                        positionY = Convert.ToInt32(Console.ReadLine());
                        if (logicTableGame[auxPositions, positionY] != "  ")
                        {
                            Console.WriteLine("No puedes realizar ese movimiento");
                        }
                        else
                        {
                            p8.PawnMove(auxPositions, positionY, p8.FirstPawnMove);
                        }
                        break;
                    default:
                        Console.WriteLine("Escoje una pieza valida");
                        break;
                }
            }
        }
    }
}
