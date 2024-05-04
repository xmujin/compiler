﻿using myapp.Model.Lexer;
using myapp.Model.Parser;
using System.Diagnostics;



namespace ConsoleTest
{

    public class Program
    {
#if false
int sum = 5 + 3;
int b = 6 / 3;
int difference = 8 - 3;
int product = 4 * 6;
int remainder = 10 % 3;
x++;
y--;
int a = 5;
a += 3; 
int result = (5 + 3) * (4 - 2);
#endif


        static void Main(string[] args)
        {


            string fileContent = File.ReadAllText(@"H:\MyTests\compile\myapp\ConsoleTest\test.txt");
            //Lexer lex = new Lexer("{\r\nint j; \r\nj = 3 + 2;\r\n}");
            Lexer lex = new Lexer(fileContent);
            Console.WriteLine(lex.GetTokens());
            
            Parser parser = new Parser(lex);
            parser.Program();
            //Console.WriteLine("Hello, World!");
            // 定义 DOT 文件路径和图像文件路径




            string dotFilePath = @"H:\MyTests\compile\myapp\ConsoleTest\test.dot";
            string pngFilePath = @"H:\MyTests\compile\myapp\ConsoleTest\binary_tree.png";
            string currentDirectory = Directory.GetCurrentDirectory();
            // 构建命令行命令
            string command = $"dot -Tpng {dotFilePath} -o {pngFilePath}";

            // 创建一个 ProcessStartInfo 对象，用于配置启动命令行的参数
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe"; // 指定要执行的命令行解释器
            startInfo.Arguments = $"/C {command}"; // 指定要执行的命令
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            // 启动一个 Process 对象，并使用指定的 ProcessStartInfo 参数启动命令行
            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
            }
        }
    }
}
