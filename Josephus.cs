using System;
using System.Collections.Generic;

/*
Josephus problem
 
Not the best solution, but is pretty clear and straight forward
*/


namespace Josephus
{

    class Entity
    {
        public int position;
        public Entity(int _position) { position = _position; }
    }


    class Program
    {
        static void Main()
        {
            int soldiers = 41;
            int iteration = 3;

            List<Entity> buffer = new List<Entity>();

            for (int i = 1; i <= soldiers; i++)
                buffer.Add(new Entity(i));

            int currIter;
            int addition = 0;
            while (buffer.Count != 1)
            {
                currIter = iteration + addition;
                while(currIter > buffer.Count)
                {
                    currIter -= buffer.Count;
                }
                buffer.RemoveAt(currIter - 1);
                addition = currIter - 1;

            }


            Console.WriteLine(buffer[0].position);
        
        
        }
    }
}
