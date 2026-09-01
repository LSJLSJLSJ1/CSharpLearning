using UnityEngine;

public class EnumExample : MonoBehaviour
{
    enum DayOfWeek
    {
        Monday, //
        Tuesday,
        Wednesday, // 2
        Thursday,
        Friday, // 4
        Saturday,
        Sunday // 6
    }

    enum Season
    {
        Spring = 6, //명시적 숫자 지정 가능
        Summer = 7,
        Autumn = 5,
        Winter // 6출력, 열거형에선 중복을 허용함.
    }

    private void Start()
    {
        //Enum이란? : 열거형, 순서대로 나열, 관련있는 데이터를 나열하여 그룹화한 형태의 상수
        DayOfWeek today = DayOfWeek.Thursday;

        if (today == DayOfWeek.Thursday)
        {
            Debug.Log("오늘은 목요일.");
        }

        Season todaySeason = Season.Summer;

        if (todaySeason == Season.Summer)
        {
            Debug.Log("지금은 여름.");
        }
        
        Debug.Log((int)today); // 3 출력
        
        today = DayOfWeek.Friday; //enum 배열은 상수지만 today는 변수임
        Debug.Log(today);
        
        
    }
}
