using System;
using System.Reflection;

namespace BasicMiniDotBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the basic MiniDot base project that can run MiniDot compiled code!");

            Assembly assembly = Assembly.LoadFrom("MiniDotBootstrap.dll");
            Type miniDotBoostrapType = assembly.GetType("MiniDotBootstrap");
            dynamic miniDotBootstrap = Activator.CreateInstance(miniDotBoostrapType);
            miniDotBootstrap.MiniDotEntryPoint();
        }
    }
}
