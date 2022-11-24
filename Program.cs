using System;
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        bool exit = false;
        CircularLinkedList<char> linklist = new CircularLinkedList<char>();
        while(exit == false)
        {
            string flower = Console.ReadLine();
            switch(flower)
            {
                case "J":
                {
                    linklist.Add(Convert.ToChar(flower));
                }
                break;
                case "G":
                {

                    linklist.Add(Convert.ToChar(flower));
                }
                break;
                case "O":
                {
                    linklist.Add(Convert.ToChar(flower));
                }
                break;
                case "R":
                {
                    linklist.Add(Convert.ToChar(flower));
                }
                break;
                default:
                {
                    exit = true;
                }
                break;
            }
        }
        Console.Write(linklist.GetLength());
        while(count < linklist.GetLength())
        {
            Console.Write(linklist.Get(count));
            count++;
        }
    }
    public void Invalid()
    {
        Console.WriteLine("Invalid pattern");
    }
    public void CheckG()
    {
        
    }
}