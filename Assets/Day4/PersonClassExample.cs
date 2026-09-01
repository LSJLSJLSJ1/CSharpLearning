using UnityEngine;

namespace Day4
{
    public class PersonClassExample : MonoBehaviour
    {
        private void Start()
        {
            Chair chair1 = new Chair();
            Chair chair2 = new Chair();
            chair2.Color = "파란색";
            // 자료형 변수명 = 값
            // 클래스 클래스명 = new 클래스

            Person lee = new Person("이성재", 25, 176.6f, 90, true);
            Person kim = new Person("김성재", 25, 176.6f, 90, true);
            
            
            //Person lee = new Person();
            //lee.Name = "이성재";
            //lee.Age = 25;
            //lee.Height = 176.6f;
            //lee.Weight = 95d;
            //lee.HasGlasses = true;
            
            lee.Run();
            lee.Introduce();
            lee.SeatDown(chair1);
            lee.SeatDown();
            
            lee.Punch(kim);

            Person park = null;
            lee.Punch(park);
        }

    }
}