using UnityEngine;

public class IfExample : MonoBehaviour
{
    private void Start()
    {
        // 코드는 일반적으로 위에서 아래로 순서대로 실행된다.
        // 이 실행 흐름을 조절하는 문법을 제어문이라고 한다.
        // 대표적인 제어문에는 조건문, 분기문, 반복문이 있다.

        // 조건문은 조건식의 결과에 따라 실행할 코드를 결정한다.
        // 비교 연산자와 논리 연산자의 결과는 bool 값이다.
        // if: 첫 번째 조건을 검사한다.
        // else if: 앞의 조건이 false일 때 다음 조건을 검사한다.
        // else: 앞의 모든 조건이 false일 때 실행된다.

        // 대표적인 예: 짝수와 홀수 판별
        int number = 7;

        if (number % 2 == 0)
        {
            Debug.Log("짝수입니다.");
        }
        else
        {
            // 정수는 짝수가 아니면 홀수이므로 별도의 else if가 필요하지 않다.
            // 이 방식은 음수 홀수도 올바르게 처리한다.
            Debug.Log("홀수입니다.");
        }

        // 중첩 조건문
        // 두 개 이상의 조건을 단계적으로 확인할 때 사용한다.
        string userInputId = "admin";
        string userInputPassword = "1234";

        const string AdminId = "admin";
        const string AdminPassword = "1234";

        if (userInputId == AdminId)
        {
            if (userInputPassword == AdminPassword)
            {
                Debug.Log("로그인에 성공했습니다.");
            }
            else
            {
                Debug.Log("비밀번호가 올바르지 않습니다.");
            }
        }
        else
        {
            Debug.Log("아이디가 올바르지 않습니다.");
        }
    }
}
