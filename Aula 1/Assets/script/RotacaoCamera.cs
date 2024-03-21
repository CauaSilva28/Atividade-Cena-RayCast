using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacaoCamera : MonoBehaviour
{
    private float rotationSpeed = 2f;
    float rotacaoY = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mouseYInput = Input.GetAxis("Mouse Y");

        rotacaoY += mouseYInput;

        rotacaoY = Mathf.Clamp(rotacaoY, -50, 15);

        transform.localEulerAngles = new Vector3(-rotacaoY, 0f, 0f);
    }
}
