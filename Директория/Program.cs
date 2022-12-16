using System;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("c:\\temp");
            Directory.CreateDirectory("c:\\temp\\K1");
            Directory.CreateDirectory("c:\\temp\\K2");
            StreamWriter sw = new StreamWriter("c:\\temp\\K1\\t1.txt");
            sw.Write("Щербаков Захар Михайлович, 15.07.2004, Россия г.Владимир");
            sw.Close();
            sw = new StreamWriter("c:\\temp\\K1\\t2.txt");
            sw.Write("Лапшин Олег, ?7.??.200?, Казахстан г.Караганда");
            sw.Close();

            sw = new StreamWriter("c:\\temp\\K2\\t3.txt");
            StreamReader sr = new StreamReader("c:\\temp\\K1\\t1.txt");
            var read = sr.ReadToEnd();
            sw.WriteLine(read);
            sr.Close();

            sr = new StreamReader("c:\\temp\\K1\\t2.txt");
            read = sr.ReadToEnd();
            sw.WriteLine(read);
            sr.Close();
            sw.Close();
            
            DirectoryInfo d = new DirectoryInfo("c:\\temp\\K1\\");
            DirectoryInfo d3 = new DirectoryInfo("c:\\temp\\K2\\");
            FileInfo[] f = d.GetFiles();
            FileInfo[] f3 = d3.GetFiles();
            Console.WriteLine("K1:");
            foreach (FileInfo i in f)
            {
                Console.WriteLine("Имя: "+i.Name.ToString() +"\n"
                    +" Путь: "+ i.FullName.ToString() + "\n"
                    + " Атрибут: "+ i.Attributes.ToString() + "\n"
                    + "Расширение: "+i.Extension.ToString() + "\n"
                    + "Размер: "+i.Length.ToString() + "\n"
                    + "Только для чтения: "+i.IsReadOnly.ToString() + "\n"
                    +"Время создания"+i.CreationTime.ToString()+"\n");
            }
            Console.WriteLine("K2:");
            foreach (FileInfo i in f3)
            {
                Console.WriteLine("Имя: " + i.Name.ToString() + "\n"
                                    + " Путь: " + i.FullName.ToString() + "\n"
                                    + " Атрибут: " + i.Attributes.ToString() + "\n"
                                    + "Расширение: " + i.Extension.ToString() + "\n"
                                    + "Размер: " + i.Length.ToString() + "\n"
                                    + "Только для чтения: " + i.IsReadOnly.ToString() + "\n"
                                    + "Время создания" + i.CreationTime.ToString() + "\n");
            }


            File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
            File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
            Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
            Directory.Delete("c:\\temp\\K1",true);

            DirectoryInfo h = new DirectoryInfo("c:\\temp\\ALL\\");
            FileInfo[] j = h.GetFiles();
            Console.WriteLine("All:\n");
            foreach (FileInfo i in j)
            {
                Console.WriteLine("Имя: " + i.Name.ToString() + "\n"
                                    + " Путь: " + i.FullName.ToString() + "\n"
                                    + " Атрибут: " + i.Attributes.ToString() + "\n"
                                    + "Расширение: " + i.Extension.ToString() + "\n"
                                    + "Размер: " + i.Length.ToString() + "\n"
                                    + "Только для чтения: " + i.IsReadOnly.ToString() + "\n"
                                    + "Время создания" + i.CreationTime.ToString() + "\n");
            }
        }
    }
}