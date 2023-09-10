﻿using System;
using System.Reflection;


namespace LinkedList2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Models.LinkedList<int> list = new Models.LinkedList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
            list.Add(6);
            list.Delete(1);
            list.AppendHead(0);
            list.AddAfterValue(5, 4);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

    }
}