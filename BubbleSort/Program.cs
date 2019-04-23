using System;
using System.Threading.Tasks.Dataflow;

namespace BubbleSort
{
    class Program
    {
        static void Main()
        {
            int[] _array = { 800, 11, 50, 771, 649, 5, 770, 240, 9, 54, 67, 8899, 2 };
            //SORTING THE ARRAY
            for (var j = 0; j < _array.Length; j++)
            {
                //SCANING THE ARRAY
                for (var i = 0; i < j; i++)
                {
                    //COMPARING THE VALUES
                    if (_array[i] > _array[j])
                    {
                        //SWAPPING VALUES TO THE CORRECT PLACE
                        int temp = _array[i];
                        _array[i] = _array[j];
                        _array[j] = temp;
                    }
                }
            }

            foreach (var number in _array)
                Console.WriteLine("{0} ", number);

            Console.ReadLine();
        }
    }
}