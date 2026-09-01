using UnityEngine;
namespace Day5
{
    public class GoldFish : Animal
    {
        private string _color;
        
        public GoldFish(string name, string color)
        {
            _name = name;
            _height = 2;
            _weight = 0.3;
        }
        
        public override void Introduce()
        {
            Debug.Log($"뻐끔 나는 {_name}이다. 내 비늘은 {_color}색이지.");
        }
    }
}
