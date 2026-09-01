using UnityEngine;
namespace Day5
{
    public class Cat : Animal
    {
        public Cat(string name, float height, float weight)
        {
            _name = name;
            _height = height;
            _weight = weight;
        }

        public override void Introduce()
        {
            Debug.Log($"야옹 나는 {_name}이다.");
        }
    }
}
