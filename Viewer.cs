using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer 
    {
        public static void Replace()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("MODO VISUALIZADOR");
            Console.WriteLine("=================");
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            string text = Console.ReadLine();
            var words = text.Split(" ");
            

            for(var i = 0; i < words.Length; i++){
                if(strong.IsMatch(words[i])){
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf(">") + 1,
                            (words[i].LastIndexOf("<") - 1) - words[i].IndexOf(">")
                        )
                    );
                    Console.Write(" ");
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}