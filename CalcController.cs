using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcWinForm
{
    class PassOffHandler
    {
        public int InputHandler()
        {
            int input = -1;
            return input;
        }
    }
    class CalcController
    {
        int ph = new PassOffHandler().InputHandler();
        string ReturnHandler()
        {
            switch (ph)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                default:
                    break;
            }
            return "";
        }
    }
    class AdditionHandler
    {

    }
    class SubtractionHandler
    {

    }
    class MultiplicationHandler
    {

    }
    class DivisionHandler
    {

    }
    class EqualsPressed
    {

    }
}
