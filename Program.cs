using System;
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        bool exit = false;
        char A,B,C,D,E,F,G,R = 'R';
        CircularLinkedList<char> linklist = new CircularLinkedList<char>();
        while(exit == false)
        {
            string flower = Console.ReadLine();
            switch(flower)
            {
                case "J":
                {
                    A = char.Parse(flower);
                    if(linklist.GetLength() > 1)
                    {
                        B = linklist.Get(linklist.GetLength()-1);
                        C = linklist.Get(linklist.GetLength()-2);
                        if(B == R && A == C)
                        {
                            Console.WriteLine("Invalid pattern");
                        }
                        else
                        {
                            linklist.Add(Convert.ToChar(flower));
                        }
                    }
                    else linklist.Add(Convert.ToChar(flower));
                }
                break;
                case "G":
                {
                    A = char.Parse(flower);
                    if(linklist.GetLength() > 2)
                    {                        
                        B = linklist.Get(linklist.GetLength()-1);
                        C = linklist.Get(linklist.GetLength()-2);
                        D = linklist.Get(linklist.GetLength()-3);
                        E = linklist.Get(0);
                        F = linklist.Get(1);
                        G = linklist.Get(2);
                        if((A == B && B == C && C == D) || (E == A && A == B && B == C) || (F == E && E == A && A == B) || (G == F && F == E && E == A) || (B == R && A == C))
                        {
                            Console.WriteLine("Invalid pattern");
                        }
                        else
                        {
                            linklist.Add(Convert.ToChar(flower));
                        }
                    }
                    else if(linklist.GetLength() > 1)
                    {
                        B = linklist.Get(linklist.GetLength()-1);
                        C = linklist.Get(linklist.GetLength()-2);
                        D = linklist.Get(linklist.GetLength()-3);
                        if(B == R && A == C)
                        {
                            Console.WriteLine("Invalid pattern");
                        }
                        else
                        {
                            linklist.Add(Convert.ToChar(flower));
                        }
                        
                    }
                    else
                    {
                        linklist.Add(Convert.ToChar(flower));
                    }
                }
                break;
                case "O":
                {
                    A = char.Parse(flower);
                    if(linklist.GetLength() > 1)
                    {
                        B = linklist.Get(linklist.GetLength()-1);
                        C = linklist.Get(linklist.GetLength()-2);
                        if(B == R && A == C)
                        {
                            Console.WriteLine("Invalid pattern");
                        }
                        else
                        {
                            linklist.Add(Convert.ToChar(flower));
                        }
                    }
                    else linklist.Add(Convert.ToChar(flower));
                }
                break;
                case "R":
                {
                    A = char.Parse(flower);
                    if(linklist.GetLength() == 0)
                    {
                        Console.WriteLine("Invalid pattern");
                    }
                    else
                    {
                        B = linklist.Get(linklist.GetLength()-1);
                        C = linklist.Get(linklist.GetLength()-2);
                        if(B == R && A == C)
                        {
                            Console.WriteLine("Invalid pattern");
                        }
                        else
                        {
                            linklist.Add(Convert.ToChar(flower));
                        }
                    }
                }
                break;
                default:
                {
                    exit = true;
                }
                break;
            }
        }
        while(count < linklist.GetLength())
        {
            Console.Write(linklist.Get(count));
            count++;
        }
    }
}