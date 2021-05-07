using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;
        private int position = -1; // 배열의 현재 위치값

        // 배열화 (배열이 아닌 MyList를 배열처럼 만들어주는 프로퍼티)
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
        //IEnumarable 사용


        public MyList()
        {
            array = new int[3]; // 0, 1, 2
        }
      
        
    }
}
