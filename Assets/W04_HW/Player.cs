using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 10.0f;
    [SerializeField] float mouseSpeed = 8f;
    private CharacterController controller;
    private float gravity;
    private Vector3 mov;

    private float mouseX;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        mov = Vector3.zero;
        gravity = 10f;

    }

    // Update is called once per frame
    void Update()
    {

        mouseX += Input.GetAxis("Mouse X") * mouseSpeed;
        this.transform.localEulerAngles = new Vector3(0, mouseX, 0);
    }

    private void FixedUpdate()
    {


        mov = new Vector3(Input.GetAxis("Horizontal"), mov.y, Input.GetAxis("Vertical"));
        mov = controller.transform.TransformDirection(mov);

        if (!controller.isGrounded)
        {
            mov.y -= gravity * Time.deltaTime;
        }
        else 
        {
            mov.y = 0f;
        }

        controller.Move(mov * Time.deltaTime * speed);
    }
    
}