using UnityEngine;

public class PlanetRotation : MonoBehaviour

   
{
    public Transform targetPlanet; 

    public float rotSpeed = 30f; // 자전속도

    public float revolutionSpeed = 100f; // 공전 속도

    public  bool isRevolution = false;



    // Update is called once per frame
    void Update()
    {
        // 자기 자신이 회전하는 기능
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if (isRevolution == true) //  조건문 > 만약 공전을 한다면,
        {
            // 공전 하는 기능
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);

        }

    }




}
