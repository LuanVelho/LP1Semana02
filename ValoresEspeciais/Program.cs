using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbytemais = sbyte.MaxValue;
            sbyte sbytemenos = sbyte.MinValue;
            short shortmais = short.MaxValue;
            short shortmenos = short.MinValue;
            int intmais = int.MaxValue;
            int intmenos = int.MinValue;
            long longmais = long.MaxValue;
            long longmenos = long.MinValue;
            byte bytemais = byte.MaxValue;
            byte bytemenos = byte.MinValue;
            ushort ushortmais = ushort.MaxValue;
            ushort ushortmenos = ushort.MinValue;
            uint uintmais = uint.MaxValue;
            uint uintmenos = uint.MinValue;
            ulong ulongmais = ulong.MaxValue;
            ulong ulongmenos = ulong.MinValue;
            float floatmais = float.MaxValue;
            float floatmenos = float.MinValue;
            Console.WriteLine(sbytemais);
            Console.WriteLine(sbytemenos);
            Console.WriteLine(shortmais);
            Console.WriteLine(shortmenos);
            Console.WriteLine(intmais);
            Console.WriteLine(intmenos);
            Console.WriteLine(longmais);
            Console.WriteLine(longmenos);
            Console.WriteLine(bytemais);
            Console.WriteLine(bytemenos);
            Console.WriteLine(ushortmais);
            Console.WriteLine(ushortmenos);
            Console.WriteLine(uintmais);
            Console.WriteLine(uintmenos);
            Console.WriteLine(ulongmais);
            Console.WriteLine(ulongmenos);
            Console.WriteLine(floatmais);
            Console.WriteLine(floatmenos);
            
            float xmais = float.PositiveInfinity;
            float xmenos = float.NegativeInfinity;
            double Nano = double.PositiveInfinity;
            Console.WriteLine(xmais);
            Console.WriteLine(xmenos);
            Console.WriteLine(Nano);

            uint i = uint.MaxValue;
            Console.WriteLine((uint)(i + 1));
            float x = 2 * float.MaxValue;
            double y = double.MaxValue + 1;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
