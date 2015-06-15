using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
        /// <summary>
        /// Non-recursive implementation of MergeSort
        /// </summary>
        /// <param name="array">Input array to get sorted.</param>
        public static void Sort( ref int[] array ) {
            if( array.Length < 2 )
                return;

            int step = 1;
            int startL, startR;
            while( step < array.Length ) {
                startL = 0;
                startR = step;
                while( startR + step <= array.Length ) {
                    Merge( ref array, startL, startL + step, startR, startR + step );
                    startL = startR + step;
                    startR = startL + step;
                }
                if( startR < array.Length )
                    Merge( ref array, startL, startL + step, startR, array.Length );
                step *= 2;
            }
        }

        private static void Merge( ref int[] array, int startL, int stopL, int startR, int stopR ) {
            int[] left = new int[ stopL - startL + 1 ];
            int[] right = new int[ stopR - startR + 1 ];

            Array.Copy( array, startR, right, 0, right.Length - 1 );
            Array.Copy( array, startL, left, 0, left.Length - 1 );

            right[ right.Length - 1 ] = Int32.MaxValue;
            left[ left.Length - 1 ] = Int32.MaxValue;

            for( int k = startL, m = 0, n = 0; k < stopR; ++k ) {
                if( left[ m ] <= right[ n ] ) {
                    array[ k ] = left[ m ];
                    m++;
                }
                else {
                    array[ k ] = right[ n ];
                    n++;
                }
            }
        }
    }
}
