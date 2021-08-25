using System;
using System.Reflection;

namespace Examples
{
    public static class CreateClass<T>
        where T : class
    {
        public static object CreateClassObject(T param)
        {
            var type = param.GetType();

            ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { });
            object obj = constructorInfo.Invoke(new object[] { });

            return obj;
        }
    }
}