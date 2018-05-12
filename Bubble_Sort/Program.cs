// ******************************************************************************************************************
//  Bubble Sort - simple spike for bubble sort algorithm.
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//

using System;
using System.Linq;

namespace Bubble_Sort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 45, 12, 23, 34 };

            //Print the initial array
            Console.WriteLine("\nThe initial array: ");
            data.ToList().ForEach(x => Console.Write($"{x} "));

            BubbleSort(ref data);

            //Print the sorted array
            Console.WriteLine("\n\nThe sorted array: ");
            data.ToList().ForEach(x => Console.Write($"{x} "));

            //Hold console
            Console.Write("\n\nPress any key to exit... ");
            Console.ReadKey();
        } // end method Main()

        public static void BubbleSort(ref int[] data)
        {
            for (int j = 0; j < data.Length - 1; j++)
            {
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        Swap(ref data[i], ref data[i + 1]);
                    }
                } // end for
            } // end for
        } // end method BubbleSort()

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        } // end method Swap
    } // end class Program
} // end namespace Bubble_Sort
