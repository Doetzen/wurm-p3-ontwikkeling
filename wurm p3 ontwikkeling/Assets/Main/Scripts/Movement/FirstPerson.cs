using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class FirstPerson : MonoBehaviour
{
    public float sensitivity = 100, mouseX, mouseY, clamp = 0;
    public Transform playerBody, cam;
   


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //cursor in midden van scherm en ontzichtbaar
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        clamp -= mouseY;
        playerBody.Rotate(Vector3.up * mouseX);
        clamp = Mathf.Clamp(clamp, -90, 90);
        transform.localRotation = Quaternion.Euler(clamp, 0f, 0f);
        //moet dingen erbij gaan schrijven wat dit betekend


    }
}