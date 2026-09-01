using NUnit.Framework;
using UnityEngine;
using Day5;

namespace Day4
{
    public class Person : Animal
    {
        // 필드(속성, 멤버, 변수,)
        // public : 외부 접근(rw) 가능.
        // private : 외부 접근 불가능.
        // 접근 제어자 : public, private, protected
        
        // 추상화에서 숨길건 숨기는 것 -> 은닉화 -> 캡슐화
        public string Name = string.Empty;
        public int Age = 0;
        public float Height = 0f;
        public double Weight = 0d;
        public bool HasGlasses = false;


        // 생성자 메서드
        // 갹체 생성시 new 키워드와 함께 호출하는 메서드
        public Person(string name, int age, float height, float weight, bool hasGlasses)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            HasGlasses = hasGlasses;
        }
        
        // 메서드(기능, 함수)
        public override void Introduce()
        {
            Debug.Log($"Hello {Name}!, {Age} years old, NTMY.");
            Debug.Log($"{Height}cm, {Weight}kg, Glasses:{HasGlasses}");
        }

        public override void Run()
        {
            Debug.Log($"Running... Speed: {Height / Weight}m/s");
        }

        // 메서드 오버로딩 : 같은 이름의 메서드를 중복하여 여러개 생성
        // 매개변수의 개수나 자료형이 달라야함.
        
        public void SeatDown()
        {
            Debug.Log("땅바닥에 앉는다.");
        }

        public void SeatDown(Chair chair)
        {
            Debug.Log($"{chair.Color}색 의자에 앉았습니다.");
        }

        public void Punch(Person otherPerson)
        {
            string Name = "닭";
            // 상곤이가 윤민이를 때렸다.
            Debug.Log($"{Name}이(가) {otherPerson.Name}을(를) 때렸다!");
        }
        // 코딩 컨벤션 : public -> 파스칼 케이스 / private -> 언더바 카멜 케이스 / 지역 변수 -> 카멜 케이스
    }

}
