using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log(obj.name); // 게임오브젝트의 이름
        Debug.Log(obj.tag); // 게임오브젝트의 태그
        Debug.Log(obj.transform.position); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log(obj.transform.rotation); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log(obj.transform.localScale); // 게임오브젝트의 Transform 컴포넌트의 크기

    }

}