using System;
using System.Reflection;
using c_sharp_namespaces.app;
using c_sharp_namespaces.test;

namespace c_sharp_namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Type appType = typeof(App);
            Type pubType = typeof(Publisher);
            PropertyInfo[] appProp = appType.GetProperties();
            PropertyInfo[] pubProp = pubType.GetProperties();
            Console.WriteLine("App Namespace: " + appType.Namespace);
            Console.WriteLine("Publisher Namespace: " + pubType.Namespace);
            Console.WriteLine("App Property Info");
            foreach (PropertyInfo pInfo in appProp)
            {
                Console.WriteLine(pInfo);
            }
            Console.WriteLine("App Publisher Info");
            foreach (PropertyInfo pInfo in pubProp)
            {
                Console.WriteLine(pInfo);
            }
            Console.ReadLine();
        }
    }
}



