using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1; // ��� ���� (�ʵ�)
    public int number2; // ��� ���� (�ʵ�)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult= AddMethod(); // �Լ� ȣ��
        int minusResult = MinusMethod(); // �Լ� ȣ��

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}");

        Debug.Log(MinusMethod());
    }

    int AddMethod()
    { 
        // ���� ���� result
        int result = number1 + number2;
        return result;  
    }
    int MinusMethod()
    { 
        // ���� ���� result
        int result = number1 - number2;
        return result;  
    }
}

   
