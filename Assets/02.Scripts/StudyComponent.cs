using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // ť�� ���� ������Ʈ

    public string changeName; // ����Ƽ���� ������ ���ڿ� ����
    
    void Start()
    {
        obj.name = changeName; // ť�� ������Ʈ�� �̸��� �ٲٴ� ���
    }

 
}
