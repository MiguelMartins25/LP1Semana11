using System;
using System.Text;

namespace StringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.Run(args);
        }
    }
}