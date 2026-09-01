using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    enum DayOfWeek
    {
        Monday, // 0
        Tuesday,
        Wednesday, // 2
        Thursday,
        Friday, // 4
        Saturday,
        Sunday // 6
    }
    private void Start()
    {
        DayOfWeek today = DayOfWeek.Thursday;
        //분기문
        //내가 원하는 값과 일치여부에 따라 코드 분기를 가를 수 있음
        switch ((int)today)
        {
            case 0:
                Debug.Log("오늘은 월요일입니다");
                break;
            case 1:
                Debug.Log("오늘은 화요일입니다");
                break;
            case 2:
                Debug.Log("오늘은 수요일입니다");
                break;               
            case 3:
                Debug.Log("오늘은 목요일입니다");
                break;
            case 4:
                Debug.Log("오늘은 금요일입니다");
                break;
            case 5:
                Debug.Log("오늘은 토요일입니다");
                break;           
            case 6:
                Debug.Log("오늘은 일일입니다");
                break;                
        }
        // 변수 today 선언, 요일따라
        // 오늘은 X요일입니다. 출력하는 코드 작성.
        int score = 95;
        switch (score / 10)
        {
         case 10:
             Debug.Log("A+");
             break;
         case 9:
             Debug.Log("A");
             break;
         case 8:
             Debug.Log("B");
             break;
         case 7:
             Debug.Log("C");  
             break;
         case 6: 
             Debug.Log("D");
             break;
         case 5:
             Debug.Log("E");
             break;
         default:  
             Debug.Log("F");
             break;
        }
        // 변수 score 선언, 점수(0~100) 따라서
        // 100점 : A+ / 90점 이상 : A / 80점 이상 : B / 70점 이상 : C 60점 이상 : D 50점 이상 : E 50점 미만 : F
    }
}
