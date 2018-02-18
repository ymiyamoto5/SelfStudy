using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3 {
    class Program {
        static void Main(string[] args) {
            //const double EPSILON = 0.00001; //丸め単位
            //double x = 0.2 * 3;
            //double y = 0.6;
            //Console.WriteLine(Math.Abs(x - y) < EPSILON); // true

            // 3.2.1
            int? value = null;
            int def = 0;
            Console.WriteLine(value != null ? value : def);
            Console.WriteLine(value ?? def);

            // ショートカット演算 （論理和で左辺がfalseなので右辺は判定されない）
            string str = null;
            if(str != null && str.StartsWith("http://")) {
                Console.WriteLine("http://ではじまります");
            }
            // 以下はNG (NullReferenceException）
            //if (str.StartsWith("http://")) {
            //}
            // ちなみに && を & に変えてもNullReferenceException。なぜなら、ショートカット演算しないため

            Console.WriteLine(sizeof(int)); // 4
            Console.WriteLine(nameof(Program)); // Program (識別子を文字列リテラルとして得る

            //if (str == null) {
            //    throw new ArgumentNullException(nameof(str));
            //}

        }
    }
}
