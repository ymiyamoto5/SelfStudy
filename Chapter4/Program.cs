//#define DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            // 4.1.1
            var score = 75;
            if (score >= 90) {
                Console.WriteLine("優");
            } else if (score >= 70) {
                Console.WriteLine("良");
            } else {
                Console.WriteLine("不可");
            }

            // 4.2.2
            //for (var i = 1; i <= 9; i++) {
            //    for (var j = 1; j <= 9; j++) {
            //        Console.Write($"{i * j,3}");
            //    }
            //    Console.WriteLine();
            //}

            // 理解度チェック1
            //var odd = 0;
            //for (var i = 100; i <= 200; i++) {
            //    if (i % 2 == 0) { continue; }
            //    odd += i;
            //}
            //Console.WriteLine(odd);

            // 2
            int i = 1;
            int sum = 0;

            while (i <= 100) {
                sum += i;
                if(sum > 1000) {
                    break;
                }
                i++;
            }
            Console.WriteLine($"合計が1000を超えるのは{i}");

//#if DEBUG
//            Console.WriteLine("デバッグ時だけ表示");
//#endif



        }
    }
}
