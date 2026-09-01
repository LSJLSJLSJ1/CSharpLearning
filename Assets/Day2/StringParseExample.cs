using UnityEngine;

public class StringParseExample : MonoBehaviour
{
    private void Start()
    {
        // Parse는 변환에 실패하면 예외가 발생하므로 입력값이 확실할 때 사용한다.
        string stringAge = "25";
        int intAge = int.Parse(stringAge);
        Debug.Log(intAge);

        string stringWeight = "70.2";
        float floatWeight = float.Parse(stringWeight);
        Debug.Log(floatWeight);

        // TryParse는 변환 성공 여부를 bool로 반환하므로 사용자 입력 처리에 안전하다.
        // "176.8cm"에는 숫자가 아닌 문자가 포함되어 있어 변환에 실패한다.
        string stringHeight = "176.8cm";
        bool isParsed = float.TryParse(stringHeight, out float floatHeight);
        if (isParsed)
        {
            Debug.Log(floatHeight);
        }
        else
        {
            Debug.Log("파싱에 실패했습니다.");
        }

        // 숫자형을 문자열로 변환할 때는 ToString을 사용할 수 있다.
        float floatValue = 174f;
        string stringValue = floatValue.ToString();
        Debug.Log(stringValue);
    }
}
