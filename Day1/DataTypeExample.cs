using UnityEngine;

public class DataTypeExample : MonoBehaviour
{
    void Start()
    {
        //자료형 : 변수에 저장되는 값의 데이터 타입
        // 숫자, 문자, 논리, 객체(오브젝트) 4가지가 대표적
        // 1. 숫자(12가지)
        // 정수 실수 등
        
        // 정수(short, int, long)
        // float 4바이트
        // double 8바이트
        // chemical 16바이트
        
        // 실수(float, double, chemical)
        short profit0 = 8883; //short의 범위는 16비트
        int profit1 = 1000000000; //int의 범위는 32비트
        long profit2 = 10000000000; //long의 범위는 64비트

        int id = 12348963;
        // 실무에서 실제 쓰는 아이템 id 사례
        // 12 : 타입
        // 34 : 직업
        // 896 : 896레벨 아이템

        // 2. 문자(열)(2가지)\
        
        // 문자(char)와 문자열(string)
        char firstName = '이';
        string lastName = "성재";

        // 3. 논리(bool)
        bool isDeleted = false;
        // is, has 등 3인칭 단수형을 앞에 붙여서 명확하게 표기하는 게 좋음

        // 4. 객체(오브젝트)(참조형)
        
        // 형변환이란?
        // -> 특정 변수에 담겨있는 데이터를 다른 데이터 타입의 변수에 할당
        // -> 이 형변환 과정에서 타입의 변화를 신경써야함

        long money1 = 32113123132312321;
        short money2 = (short)money1; // 명시적 형 변환 -> 2817 출력


        int maxHealth1 = 88888;
        long maxHealth2 = 34;
        maxHealth2 = (long)maxHealth1; // 작->큰 변환은 명시 필요없음
        
        //반면 초기 선언 이후 수정 불가능한 값은 상수라고 부름
        const int MaxHealth3 = 500; //파스칼 케이스 추천
        // MaxHealth3 = 23; // 에러 발생

        const int gameWidth = 10;
        const int gameHeight = 30; //등 바뀌면 안될 값에 대해 const 선언
        
        Debug.Log(money1);
        Debug.Log(money2);
        
        
    }
}
