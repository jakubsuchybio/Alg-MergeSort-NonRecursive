﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MergeSort;

namespace MergeSortTests
{
    [TestClass]
    public class MergeSortTests
    {

        [TestMethod]
        public void SortOne() {
            int[] input = new int[] { 5 };

            MergeSort.MergeSort.Sort( ref input );

            CollectionAssert.AreEqual( new int[] { 5 }, input );
        }

        [TestMethod]
        public void SortTwo() {
            int[] input = new int[] { 5, 4 };
            int[] expected = new int[] { 4, 5 };

            MergeSort.MergeSort.Sort( ref input );

            CollectionAssert.AreEqual( expected, input );
        }

        [TestMethod]
        public void SortTwo2() {
            int[] input = new int[] { 4, 5 };
            int[] expected = new int[] { 4, 5 };

            MergeSort.MergeSort.Sort( ref input );

            CollectionAssert.AreEqual( expected, input );
        }

        [TestMethod]
        public void SortFive() {
            int[] input = new int[] { 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            MergeSort.MergeSort.Sort( ref input );

            CollectionAssert.AreEqual( expected, input );
        }

        [TestMethod]
        public void SortN() {
            int N = 10000;
            for( int i = 0; i < N; i++ ) {
                int[] input = new int[i];
                Random rnd = new Random();
                for( int j = 0; j < input.Length; ++j )
                    input[ j ] = rnd.Next( N );
                int[] expected = new int[ i ];
                Array.Copy( input, expected, i );
                Array.Sort( expected );

                MergeSort.MergeSort.Sort( ref input );

                CollectionAssert.AreEqual( expected, input );

            }

        }
    }
}
