using System;
using UnityEngine;

namespace Day4
{
    public class Array2DExample : MonoBehaviour
    {
        private void Start()
        {
            // 2차원 배열(타일 기반 게임에 주로 사용)
            // 3amth 퍼즐, 플랫포머, 인벤토리
            int[,] enemyHealths = new int[2, 3];
            enemyHealths[0, 0] = 1;
            enemyHealths[0, 1] = 2;
            enemyHealths[0, 2] = 3;
            enemyHealths[1, 0] = 4;
            enemyHealths[1, 1] = 5;
            enemyHealths[1, 2] = 6;
            
            Debug.Log(enemyHealths[1, 1]); // 5 출력
            
            // 1. 배열은 캐시 히트를 위해 row 우선으로 접근. -> 행 단위로 캐싱이 되기 때문
            for (int col = 0; col < enemyHealths.Length; col++)
            {
                for (int row = 0; row < enemyHealths.Length; row++)
                {
                    Debug.Log($"enemyHealths [{col}[row] : {enemyHealths[col, row]}]");
                }
            }
        }
    }
}