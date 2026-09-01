using UnityEngine;

namespace Day5
{
    public class Dog : Animal
    {
        public Dog(string name, float height, float weight)
        {
            _name = name;
            _height = height;
            _weight = weight;
        }
    
        public override void Introduce()
        {
            Debug.Log($"멍멍 나는 {_name}이다.");
        }
    }
}
