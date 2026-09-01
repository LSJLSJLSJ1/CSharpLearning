using UnityEngine;

public class StringFormatExample : MonoBehaviour
{
    private void Start()
    {
        // + 연산자를 사용한 문자열 연결
        int age = 25;
        string name = "이성재";
        bool isMale = true;
        Debug.Log("Name: " + name + " Age: " + age + " isMale: " + isMale);

        // string.Format의 자리표시자 사용
        string introduceString1 = string.Format("My name is {0} and I'm {1} years old. Someone called me a real man, and it's {2}.", name, age, isMale);
        Debug.Log(introduceString1);

        // $ 기호를 사용한 문자열 보간
        string introduceString2 = $"My name is {name} and I'm {age} years old. Someone called me a real man, and it's {isMale}.";
        Debug.Log(introduceString2);

        float height = 182.7654f;
        int won = 123456789;
        Debug.Log(height);
        Debug.Log(won);

        // F1: 소수점 첫째 자리까지 표시하며 반올림한다.
        Debug.Log(string.Format("{0:F1}", height)); // 182.8

        // N0: 소수점 없이 천 단위 구분 기호를 표시한다.
        Debug.Log(string.Format("{0:N0}", won)); // 123,456,789

        int hour = 3;
        int minute = 13;

        // D2: 최소 두 자리로 표시하고 빈 자리를 0으로 채운다.
        Debug.Log($"{hour:D2}:{minute:D2}");
    }
}
