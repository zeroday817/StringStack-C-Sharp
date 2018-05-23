using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program2
    {

        static int Main(string[] args)
        {

            uint size = 0;
            CreateStack(ref size);

            Stack stack = new Stack(size);

            start();
            @switch(stack);

            return 0;
        }

        public static void CreateStack(ref uint size) {

            bool sized = false;

            do
            {

                Console.Clear();
                Console.Write("Enter the size from 1 to 9 : ");

                try
                {

                    size = Convert.ToUInt16(Console.ReadLine());
                }
                catch
                {

                }

                if (size >= 1 && size <= 9)
                {

                    sized = true;
                }

            } while (!sized);

            Console.Clear();
        }

        public static int @switch(Stack stack) {

            string str = "";

            while (true)
            {

                str = Console.ReadLine();
                switch (str)
                {

                    case "add":
                        {
                            add(str, stack);
                            break;
                        }

                    case "delete":
                        {

                            delete(stack,0);
                            break;
                        }

                    case "delete_all":
                        {

                            delete_all(stack);
                            break;
                        }

                    case "print":
                        {

                            print(stack);
                            break;
                        }

                    case "clear":
                        {

                            Console.Clear();
                            break;
                        }

                    case "create_file":
                        {

                            create_file(stack);
                            break;
                        }

                    case "exit":
                        {

                            return 0;
                        }

                    case "help":
                        {

                            help();
                            break;
                        }

                    default:
                        {

                            @default(str);
                            break;
                        }
                }
            }
        } 

        public static void create_file(Stack stack)
        {

            FileStream file1 = new FileStream("C:\\new_file.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);

            foreach (string strr in stack.stck)
            {
                writer.Write(strr + "\n");
            }
            writer.Close();

            Console.WriteLine("File was created in C:\\new_file.txt");
        }

        public static void start()
        {

            Console.WriteLine("Stack.\nLebedev Kirill 22.05.2018 12:56");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Commands:\n\t: add\n\t: delete \n\t: delete_all\n\t: clear\n\t: print\n\t: create_file\n\t: exit");
        }

        public static void add(string str, Stack stack)
        {

            Console.Clear();
            Console.Write(": ");
            str = Console.ReadLine();

            Console.Clear();

            stack.Push(str);
        }

        public static void delete(Stack stack,uint num)
        {

            Console.Clear();

            if (num == 0){

                stack.Pop();
            }
        }

        public static void delete_all(Stack stack) {

            Console.Clear();
            stack.deleteAll();
        }

        public static void print(Stack stack)
        {

            Console.Clear();
            stack.Print();
        }

        public static void @default(string str)
        {

            Console.Clear();
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -unknown command");
            Console.ResetColor();
        }

        public static void help() {

            Console.Clear();
            Console.WriteLine("Commands:\n\t: add\n\t: delete \n\t: delete_all\n\t: clear\n\t: print\n\t: create_file\n\t: exit");
        }

    }
}
