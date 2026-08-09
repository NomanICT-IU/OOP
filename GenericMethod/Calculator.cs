using System.Numerics;

namespace GenericMethod
{
    public class Calculator<T> where T : INumber<T>
    {


        /// <summary>
        /// Add method take 2 arguments
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        public T Add(T param1, T param2)
        {
            return param1 + param2;
        }
    }
}
