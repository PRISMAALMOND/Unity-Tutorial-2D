using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임 오브젝트

    public string changeName; // 유니티에서 설정할 문자열 변수
    
    void Start()
    {
        obj.name = changeName; // 큐브 오브젝트의 이름을 바꾸는 기능
    }

 
}
