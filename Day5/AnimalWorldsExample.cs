using Day4;
using UnityEngine;

namespace Day5
{
    public class AnimalWorldsExample : MonoBehaviour
    {

        private void Start()
        {
            Animal person1 = new Person("이성재", 25, 176f, 90, false);
            Animal cat1 = new Cat("삠삐", 30, 10);

            Animal person2 = new Person("삼성재", 21, 179f, 45, false);
            Animal dog1 = new Dog("누리", 50, 15);
            //다형성
            // 하나의 객체가 여러 타입을 가질 수 있는 성질.

            Animal goldfish1 = new GoldFish("붕이", "Red");

            person1.Introduce();
            cat1.Introduce();

            Animal[] animals = new Animal[]
            {
                person1, cat1, person2, dog1, goldfish1
            };
            
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Introduce();

                if (animals[i] is Person) //is 체크후 명시적 형변환
                {
                    Person person = (Person)animals[i];
                    person.SeatDown();
                }
                
                Person pperson = animals[i] as Person; //as 형변환
                if (pperson != null)
                {
                    pperson.SeatDown();
                }
            }
        }
    }
}
