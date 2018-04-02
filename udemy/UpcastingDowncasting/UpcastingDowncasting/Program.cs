using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingDowncasting
{
    class Program
    {

        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text) shape;
            //text.


            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new FileStream());
            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("John");
            //list.Add(new Text());

            //var anotherList = new List<Shape>();
        }
    }
}
