using System;
using System.Text;
using System.IO;
namespace EditorHTML
{
    public static class Editor{

        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("===========");
            string text = "";
            var file = new StringBuilder();
            
            do{
                text += Console.ReadLine();
                text += Environment.NewLine;
            }while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("----------");
            Console.WriteLine(" Deseja salvar o arquivo? ");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            var optionSave = short.Parse(Console.ReadLine());

            switch(optionSave){
                case 1: Save(text); break;
                case 2: Console.WriteLine("Não Salvar"); break;
            }
        }
        public static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho na qual você deseja salvar o arquivo: ");
            var path = Console.ReadLine();

            using(var file2 = new StreamWriter(path)){
                file2.Write(text);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Arquivo salvo com sucesso");
            Console.WriteLine(" ");
            
        }
    }

    
}