﻿using System;

namespace Snippet_6
{
    public delegate void PrintDetails();
    class TestEvent
    {
        event PrintDetails Print;
        void Show()
        {
            Console.WriteLine("This program illustrate how to subscribe objects to an event");
            Console.WriteLine("This method will not execute since the event has not been raised");
        }
        static void Main(string[] args)
        {
            TestEvent objTestEvent = new TestEvent();
            objTestEvent.Print += new PrintDetails(objTestEvent.Show);
            objTestEvent.Print();
        }
    }
}
