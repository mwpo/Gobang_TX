using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public static class ExtensionMethod
    {
        public static void ForEach(this CharMatrix self, Action<List<char>> action)
        {
            foreach (List<Char> row in self)
            {
                action(row);
            }
        }

        public static List<char> InitWithValue(this List<char> self, int times, char value)
        {
            for(int i = 0; i < times; i ++)
                self.Add(value);

            return self;
        }

    }
}