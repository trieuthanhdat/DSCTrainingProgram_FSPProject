using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField] float mouseSpeed = 2f;
    [SerializeField] Camera camera;
    Vector3 rotateDirection;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        rotateDirection += new Vector3(mouseY, mouseX, 0) * mouseSpeed;
        camera.transform.rotation = Quaternion.Euler(rotateDirection);

    }
}
