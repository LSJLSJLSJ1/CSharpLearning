using System;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    private void Start()
    {
        // For While 2가지가 대표적
        // for (초기식, 조건식, 증감연산자) {}
        // 초기식 : 처음 1회 실행.-*                        
        
        // 조건식 : 비교연산자. 보통 루프 종료 조건을 설정.
        // 증감연산자 : i++ 등
        
        //1부터 1000까지 짝수만 더하는 반복문
        int i;
        int sum = 0;
        for (i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }

        // 구구단 (단 5단 제외)
        // 점프문을 사용해야함. 브레이크 및 컨티뉴
        // 브레이크는 현재 루프나 분기를 아예 탈출해버림
        // 컨티뉴는 현재 루프만 끊고 다음 루프 실행
        int j, k;
        for (j = 2; j <= 9; j++)
        {
            if ( j == 5) continue;
            Debug.Log($"{j}단 시작");
            
            for (k = 2; k <= 9; k++)
            {
                Debug.Log($"{j} x {k} = {j * k}");
            }
        }
    }
}
