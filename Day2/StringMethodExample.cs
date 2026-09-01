using Unity.VisualScripting;
using UnityEngine;

public class StringMethodExample : MonoBehaviour
{
    private void Start()
    {
        // string은 불변이므로 메서드 호출 결과를 다시 대입해야 변경 내용이 유지된다.
        string name = "황금독수리 세상을 놀라게 하다.   ";
        Debug.Log(name.Length);

        int index = name.IndexOf("놀");
        Debug.Log(index); // 10 출력
        
        bool isHwang = name.StartsWith("황");
        Debug.Log(isHwang); // True

        bool isContainEagle = name.Contains("독수리");
        Debug.Log(isContainEagle); // True
        
        // 문자열 변형 메서드는 새로운 문자열을 반환한다.
        name = name.Trim();
        Debug.Log(name);

        name = name.Insert(6, "온"); // "세상" 앞에 "온" 삽입
        Debug.Log(name);

        int periodIndex = name.IndexOf('.');
        if (periodIndex >= 0)
        {
            name = name.Remove(periodIndex, 1); // 시작 위치에서 한 글자 제거
            
        }

        name = name.Replace("온세상", "전 세계");
        Debug.Log(name);
        
        string name2 = "Karina";
        name2 = name2.ToUpper();
        Debug.Log(name2);

        name2 = name2.ToLower();
        Debug.Log(name2);
    }
}
