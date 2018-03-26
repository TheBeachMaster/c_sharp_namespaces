using System;
using System.Reflection;
using c_sharp_namespaces.app;
using c_sharp_namespaces.test;

namespace c_sharp_namespaces
{
    enum Classes
    {
        Test,
        App
    }
    class Program
    {
        Classes testClass = Classes.Test;
        Classes appClass = Classes.App;

        
        static void Main(string[] args)
        {
            Type appType = typeof(App);
            Type pubType = typeof(Publisher);
            PropertyInfo[] appProp = appType.GetProperties();
            PropertyInfo[] pubProp = pubType.GetProperties();
            Console.WriteLine("App Namespace: " + appType.Namespace);
            Console.WriteLine("Publisher Namespace: " + pubType.Namespace);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}



