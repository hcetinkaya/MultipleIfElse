using System;

namespace MultipleIfElse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string criteria = "open";
            switch (criteria)
            {
                case "open": Console.WriteLine("Open"); break;
                case "close": Console.WriteLine("Close"); break;
                case "print": Console.WriteLine("Print"); break;
            }

            IAction open = new Open();
            open.DoWork();

            Console.Read();
        }
    }

    public interface IAction { void DoWork(); }
    public class Open: IAction { public void DoWork() { Console.WriteLine("Open"); } }
    public class Close: IAction { public void DoWork() { Console.WriteLine("Close"); } }
    public class Print: IAction { public void DoWork() { Console.WriteLine("Print"); } }
}