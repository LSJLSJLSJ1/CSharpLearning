using System;
using UnityEngine;

namespace Day3
{
    public class ArrayExample : MonoBehaviour
    {
        private void Start()
        {
            //배열 : 같은 자료형 테이터 그룹화 -> 연관 데이터 관리
            
            //배열(변수)선언
            //자료[] 배열명 = new 자료형[크기(개수)]
            int[] monsterHealths = {1, 2, 3, 4, 5}; // 자료형 50개 (4바이트 x 50개)
            int[] monsterPowers = new int[5] {1, 2, 3, 4, 5};
            
            monsterHealths[0] = 0;
            monsterHealths[1] = 1;
            monsterHealths[2] = 2;
            monsterHealths[3] = 3;
            monsterHealths[4] = 4;
            
            for (int i = 0; i < monsterHealths.Length; i++)
            {
                Debug.Log($"monster {i + 1}: Health = {monsterHealths[i]}");
            }

            int[] ages = new int[4] { 3, 1, 4, 2 };
            Array.Sort(ages);
            Array.Reverse(ages);
            foreach (int age in ages)
            {
                Debug.Log($"age = {age}");
            }
        }
    }
}