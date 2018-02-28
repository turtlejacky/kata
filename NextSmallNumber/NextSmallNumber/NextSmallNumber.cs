using System;

namespace NextSmallNumber
{
    public class NumberClass
    {
        char[] inputArray;
        public NumberClass( long input ){
            inputArray = input.ToString().ToCharArray();
            
        }
        public long NextSmaller() {
            int preIndex = inputArray.Length - 2;  // start from last 2 Index
            while ( preIndex >= 0 ) {
                int Swapindex = FindBiggestOfSmallThanPreIndex(preIndex);
                if ( Swapindex != -1 ) {
                    if (SwapIndexIsZeroAndFirstIndex(Swapindex, preIndex))
                        return -1;
                    else
                    {
                        Swap(Swapindex, preIndex);
                        Sort(preIndex+1);
                        return long.Parse(new string(inputArray));
                    }
                }
                preIndex--;
            }

            return -1;
        }

        public int FindBiggestOfSmallThanPreIndex( int preIndex ){
            int targetIndex = -1, nowValue = -1;
            for (int x = preIndex+1; x < inputArray.Length ; x++ ) {
                if ( inputArray[preIndex] > inputArray[x] &&
                    nowValue < inputArray[x] ) {
                    targetIndex = x;
                    nowValue = inputArray[x];
                }
            }

            return targetIndex;
        }

        bool SwapIndexIsZeroAndFirstIndex( int Swapindex, int preIndex ) {
            if (inputArray[Swapindex] == '0' && preIndex == 0 )
                return true;
            else
                return false;
        }

        void Swap( int a , int b ){
            char temp = inputArray[a];
            inputArray[a] = inputArray[b];
            inputArray[b] = temp;
            
        }

        void Sort( int start ) {
            for (int i = start; i < inputArray.Length; i++  ){
                for (int j = i+1; j < inputArray.Length;j++ ) 
                    if (inputArray[i] < inputArray[j])
                        Swap(i, j);
            }
        }
    }
}
