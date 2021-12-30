using System;

namespace EditorHTML
{       
    public class Menu
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Tema();
            Options();

            Console.SetCursorPosition(9,6);
            var option = short.Parse(Console.ReadLine());
            ChooseOptions(option);
        }

        public static void Tema()
        {
            
            Console.Write("+");
            for(var line = 0; line <= 20; line++){
                Console.Write("--");
            }
            Console.Write("+");
            Console.Write("\n");
            

            for(var i = 0; i <= 20; i++){
                Console.Write("|");
                    for(var j = 0; j <= 41; j++){
                        Console.Write(" ");
                    }
                Console.Write("|");
                Console.Write("\n");
            }


            Console.Write("+");
            for(var line = 0; line <= 20; line++){
                Console.Write("--");
            }
            Console.Write("+");
            Console.Write("\n");
            
        }
    
        public static void Options()
        {
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("Editor de Texto");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("===========");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("2 - Visualizar arquivo");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Opção: ");
        
        }

        public static void ChooseOptions(short option)
        {
            switch(option){
                case 1: Editor.Show(); break;
                case 2: Viewer.Replace() ;break;
                case 0:{
                    Console.Clear();
                    Environment.Exit(0);break;
                }
                default: Show(); break;
            }
        }
    
    
    }
}