using System;
using TestInfo;
using System.Runtime.Remoting;

namespace CreateObject
{
    class ObjectCreator
    {
        public static void Main()
        {
            //First argument is Assembly Name(i.e dll name)
            //Second argument is Namespace and class name
            ObjectHandle handle = Activator.CreateInstance("Sample", "TestInfo.Test");
            var createdObject = handle.Unwrap();
            var typeCastedCreatedObject=Convert.ChangeType(createdObject, createdObject.GetType());
            var prop = typeCastedCreatedObject.GetType().GetProperty("Data");
            if (prop != null)
                prop.SetValue(typeCastedCreatedObject, "Sreemat");
            var methodInfo = typeCastedCreatedObject.GetType().GetMethod("get_Data");
            var methodResult = methodInfo.Invoke(typeCastedCreatedObject, null);
            if (methodResult != null)
                Console.WriteLine(methodResult);
            Console.ReadLine();
        }
    }
}
