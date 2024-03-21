using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoRotacao : MonoBehaviour
{
    private float velocidadeh = 15f;
    private float velocidadev = 20f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private float rotationSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * velocidadeh, 0, Input.GetAxis("Vertical") * velocidadev);
        moveDirection = transform.TransformDirection(moveDirection);

        controller.Move(moveDirection * Time.deltaTime);

        //------------

        float mouseXinput = Input.GetAxis("Mouse X");

        transform.Rotate(0f, mouseXinput * rotationSpeed, 0f);
    }
}
