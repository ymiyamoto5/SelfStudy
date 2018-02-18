using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2 {
    class Program {
        static void Main(string[] args) {
            var value = 10d;
            var name = "abc";
            Console.WriteLine($"Hello {name}!");
            //int? i = null;
            //int[,] data = new int[5, 4];

            int[][] jagArray = new int[][]{
                new[] { 2, 3, 5 },
                new[] { 1, 2 },
                new[] {10,11,12,13 },
            };
            foreach (var datalist in jagArray) {
                foreach (var data in datalist) {
                    Console.WriteLine(data);
                }
            }

        }
    }
}
