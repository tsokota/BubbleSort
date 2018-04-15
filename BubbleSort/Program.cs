using System;

namespace BubbleSort
{
    class Program
    {
   
        static void Main()
        {
            int[] _array = { 800, 11, 50, 771, 649, 770, 240, 9 };
            int parkingLot;            
            bool sorted = false;
            //SORTING THE ARRAY
            while (!sorted)
            {
                sorted = true;
                //SCANING THE ARRAY
                for (var i = 0; i < _array.Length -1; i++)
                {
                    if (_array[i] > _array[i + 1])
                    {
                        parkingLot = _array[i];
                        _array[i] = _array[i + 1];
                        _array[i + 1] = parkingLot;
                        sorted = false;
                    }
                }
            }foreach(var number in _array)
            {
                Console.WriteLine("{0}", number);
            }         
      
        Console.ReadLine();

        }
    }
}
