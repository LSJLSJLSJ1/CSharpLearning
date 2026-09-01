using UnityEngine;

// 상속이란 : 부모 클래스 속성과 기능을 자식 클래스가 물려받아 사용/확장/재정의
// 코드 재사용 / 확장 / 재정의의 이점
namespace Day5
{
    public abstract class Animal
    {
        protected string _name = string.Empty;
        protected float _height = 0f;
        protected double _weight = 0f;
        
        //virtual을 통해 자식 클래스에서 override 허용

        public abstract void Introduce(); // 추상 메서드 -> 구현이 없는 메서드이므로 하위 클래스에서 무조건 구현을 해야함
    
        public virtual void Run()
        {
            Debug.Log($"{_name} 뜁니다. 속도 : {100 - (_height / _weight)}");
        }
    }
}
