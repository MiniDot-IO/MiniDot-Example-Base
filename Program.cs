using System;
using System.Linq;
using System.Reflection;
namespace BasicMiniDotBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am the basic MiniDot base project that can run MiniDot compiled code!");

            try
            {
                Assembly assembly = Assembly.LoadFrom("MiniDotBootstrap.dll");
                Type miniDotBoostrapType = assembly.GetTypes().Where(type => type.Name == "MiniDotBootstrap").FirstOrDefault();
                if (miniDotBoostrapType == null)
                {
                    Console.WriteLine("Error: the specified code doesn't have the right class.");
                }
                else
                {
                    dynamic miniDotBootstrap = Activator.CreateInstance(miniDotBoostrapType);
                    miniDotBootstrap.MiniDotEntryPoint();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
    }
}
