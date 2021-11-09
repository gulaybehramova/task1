using System;

namespace task1
{
    public enum Type
    {
        Programming = 1,
        Design,
        System
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Group group = new Group(Type.Programming);
        }
    }
}
