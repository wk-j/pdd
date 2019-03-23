using System;
using System.Linq;

namespace Pdd {
    class Program {
        // @todo Convert to asyc
        static void Main(string[] args) {
            if (args.Length > 0) {
                Console.WriteLine("Hello World! - {0}", args.First());
            }
        }
    }
}