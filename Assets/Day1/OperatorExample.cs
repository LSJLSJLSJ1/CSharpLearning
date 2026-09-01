using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 연산 : 주어신 식을 계산해서 결과 반환
        // 연산자 : 연산 기호
        
        // 수학 연산자 (산술 연산자 : 사칙 연산 수행)
        // + - * / % 등

        int number1 = 200;
        int number2 = 300;
        int result = number1 + number2;
        
        
        Debug.Log(result);
        
        // 대입 연산자
        string myName = "박보검";

        // 증감 연산자: 값을 +- 1씩 증감할 때 사용
        int age1 = 27;
        age1++; //후위 증감 연산자
        int age2 = 24;
        ++age2; //전위 증감 연산자

        int age3 = 30;
        age3 += 3; 
        
        // 비교 연산자 : 양쪽값 비교하여 bool 반환
        int student1Age1 = age1;
        int student1Age2 = age2;
        
        Debug.Log(student1Age1 == student1Age2);
        Debug.Log(student1Age1 != student1Age2);
        Debug.Log(student1Age1 > student1Age2);
        
        // AND OR NOT
        // AND : 양쪽 값 모두 True 일때 True 반환
        // OR : 양쪽 값 하나라도 True 일때 True 반환
        // NOT : 단항 기준 Bool값 반전

        // 삼항 연산자 : 조건식 사용, 참 거짓이냐에 따라 다른 값 대입
        int health = 100;
        int damage = 50;
        bool isKilled = health - damage <= 0 ? true : false;


    }
}
