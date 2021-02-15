using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    CameraManager cameraManager;
    public Rigidbody rb;
    public float moveSpeed = 5f;
    public float jumpHeight;
    public float jumpForce;

    public float rotationSpeed;
    private Vector3 Jump;
    private bool onGround = true;
    //private const int MAX_JUMP = 2;
    //private int currentJump = 0;

public void Awake()
    {
        cameraManager = FindObjectOfType<CameraManager>();
    }
    
    void Start (){

        Jump = new Vector3(0f, jumpHeight, 0f);
        rb = GetComponent<Rigidbody>();
        
    }

    void Update() {

        
        //player movement


        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
        rb.velocity.Normalize();


        //player jump

        if(Input.GetButtonDown("Jump") && (onGround)) //|| MAX_JUMP > currentJump)) //jump button=spacebar
        {
                rb.AddForce(Jump * jumpForce, ForceMode.Impulse);
                onGround = false;
                //currentJump++;
        }

        //player rotate

        if (rb.velocity != Vector3.zero){

            Quaternion toRotation = Quaternion.LookRotation(rb.velocity, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

    }

    private void LateUpdate()
    {

        cameraManager.FollowTarget();
    }

}

    /*void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        onGround = true;
        //currentJump = 0;
    }*/