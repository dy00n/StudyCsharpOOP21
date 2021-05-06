using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;

        public int Length { get; internal set; }

        public int this[int index] // == MyList[i] == array[i]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index>=array.Length) // 3보다 크면 하나씩 증가
                {
                    System.Array.Resize(ref array, index + 1); // 4로 증가
                    Console.WriteLine($"Array resized : {array.Length}");
                }

                array[index] = value;
            }
        }
        public int length
        {
            get { return array.Length; }
        }

        public MyList()
        {
            array = new int[3]; // 0, 1, 2
        }
        
    }
}
