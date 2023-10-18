using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess_SAEG.Moves
{
    public class ToolsForUserExperiences
    {
        public int ConvertLettersToNumbers(char letter)
        {
            switch (letter)
            {
                case 'A':
                    return 0;
                case 'B':
                    return 1;
                case 'C':
                    return 2;
                case 'D':
                    return 3;
                case 'E':
                    return 4;
                case 'F':
                    return 5;
                case 'G':
                    return 6;
                case 'H':
                    return 7;
                default:
                    return 7;
            }
        }
        public char ForTheTableGame(int iterationVisible)
        {
            switch (iterationVisible)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                case 3:
                    return 'D';
                case 4:
                    return 'E';
                case 5:
                    return 'F';
                case 6:
                    return 'G';
                case 7:
                    return 'H';
                default:
                    return '0';
            }
        }
    }
}
