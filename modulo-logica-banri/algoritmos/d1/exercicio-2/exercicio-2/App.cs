using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class App
    {
        static void Main(string[] args)
        { //"" é pra string e '' pra char
            char emoji_1 = '😊'; //Error CS1012  Too many characters in character literal    exercicio - 2 C: \Users\E38305\Desktop\modulo - logica - banri\algoritmos\exercicio - 2\exercicio - 2\App.cs   13  Active
            char emoji_2 = '☺'; 

            char letra_a = 'A'; //65
            int numero_a = letra_a;

            string valor_bool = "TRUE";
            bool valor_true = System.Convert.ToBoolean(valor_bool);

            double game_score = 51.49;
            int balas_premio = System.Convert.ToInt16(game_score);

            System.Console.WriteLine(emoji_1);
            System.Console.WriteLine(emoji_2);
            System.Console.WriteLine(numero_a);
            System.Console.WriteLine(valor_true);
            System.Console.WriteLine(balas_premio);
        }
    }
}
