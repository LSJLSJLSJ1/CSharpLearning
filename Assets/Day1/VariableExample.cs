using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug; //네임스페이스

public class VariableExample : MonoBehaviour //클래스
{
    void Start() // 비어있는 메서드(함수)
    {
        //변수 : 데이터를 저장, 조회, 수정할 수 있도록 메모리로부터 할당받은 공간.
        //크기 설정에 따라 담을 수 있는 데이터 크기가 다름.
        //타입에 따라 담을 수 있는 데이터 형식이 다름.
        //타입 -> 변수명, 변수는 변수명까지 포함
        
        //변수 선언 : 필요한 공간만큼 메모리로부터 할당.
        //선언에 포함되어야 하는 것 : 공개 범위(선), 타입(필), 크기, 이름(필) 등
        int health;
        int damage;
        float exp;
        string name;
        double speed;
        
        // 변수이름은 대소문자 구분함
        
        
        // 변수 사용전 초기 값을 설정해두는 것이 좋음.
        string name1 = "이성재";
        int age = 27;
        float height = 176.6f;
        double weight = 95d;
        bool isDie = false;

        Debug.Log(name1);
        Debug.Log(age);
        Debug.Log(height);
    }
}
