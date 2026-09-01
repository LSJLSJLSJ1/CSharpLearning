using System;
using UnityEngine;

namespace Day3
{
    public class WhileExample : MonoBehaviour
    {
        private void Start()
        {
            // while 반복문 : 조건식 참일때만 반복실행.
            /// for와 다르게 괄호 내부에만 조건식 들어감.

            int i = 0;

            while (i < 1000)
            {
                i++;
            }
            
            //while 반복 순서의 조건이 유동적일 때 사용하면 용이함
        }
    }
}