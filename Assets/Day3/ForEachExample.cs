using System;
using UnityEngine;

public class ForEachExample : MonoBehaviour
{
    private void Start()
    {
        string myName = "황금독수리온세상을놀라게하다";
        Debug.Log(myName);
        Debug.Log(myName[0]); //황
        Debug.Log(myName[1]); //금
        Debug.Log(myName[myName.Length - 1]); //다
        
        for(int i = 0; i < myName.Length; i++)
        {
            Debug.Log(myName[i]); 
        }
        
        
        
        // foreach란? -> 배열/컬렉션 요소를 처음~끝 까지 순서대로 간편하게 접근할 때 사용
        foreach (char c in myName)
        {
            Debug.Log(c);
        }
    }
}
