using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    void Start()
    {
        // Player��� Tag�� ���� ���ӿ�����Ʈ�� ã�Ƽ� obj�� �Ҵ�
        obj = GameObject.FindGameObjectWithTag("Player");

        Debug.Log(obj.name); // ���ӿ�����Ʈ�� �̸�
        Debug.Log(obj.tag); // ���ӿ�����Ʈ�� �±�
        Debug.Log(obj.transform.position); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ��ġ
        Debug.Log(obj.transform.rotation); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ȸ��
        Debug.Log(obj.transform.localScale); // ���ӿ�����Ʈ�� Transform ������Ʈ�� ũ��

    }

}