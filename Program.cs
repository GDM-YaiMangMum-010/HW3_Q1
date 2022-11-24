﻿using System;
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
                    if(count<3)
                    {
                        linklist.Add(Convert.ToChar(flower));
                        count++;                        
                    }
                    else
                    {        
                        Console.WriteLine("Invalid pattern");
                        linklist.Remove(1);
                        count--;
                    }
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
    }
    public void Invalid()
    {
        Console.WriteLine("Invalid pattern");
    }
}