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

using NUnit.Framework;
using static Bubble_Sort.Program;

namespace Bubble_Sort_Test
{
    [TestFixture]
    public class BubbleTest
    {
        int[] pre1, pre2, pre3, pre4;
        int[] post1, post2, post3, post4;

        [SetUp]
        public void TestSetUp()
        {
            pre1 = new int[] { 4, 3, 2, 1 };
            post1 = new int[] { 1, 2, 3, 4 };
            pre2 = new int[] { 43, 66, 21, 5 };
            post2 = new int[] { 5, 21, 43, 66 };
            pre3 = new int[] { 7, 8, 2, 7 };
            post3 = new int[] { 2, 7, 7, 8 };
            pre4 = new int[] { 1, 1, 1, 1 };
            post4 = new int[] { 1, 1, 1, 1 };
        }

        [Test (Description = "Bubble Test 1")]
        public void Bubble_Sort_Test1()
        {
            BubbleSort(ref pre1);
            Assert.AreEqual(pre1, post1);
        }

        [Test(Description = "Bubble Test 2")]
        public void Bubble_Sort_Test2()
        {
            BubbleSort(ref pre2);
            Assert.AreEqual(pre2, post2);
        }

        [Test(Description = "Bubble Test 3")]
        public void Bubble_Sort_Test3()
        {
            BubbleSort(ref pre3);
            Assert.AreEqual(pre3, post3);
        }

        [Test(Description = "Bubble Test 4")]
        public void Bubble_Sort_Test4()
        {
            BubbleSort(ref pre4);
            Assert.AreEqual(pre4, post4);
        }
    } // end class BubbleTest
} // end namespace Bubble_Sort_Test
