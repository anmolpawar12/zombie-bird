using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class player : MonoBehaviour
{
    Animator ani;
    Rigidbody rb;
    private bool jump = false;
    
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();


        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gamemanager.instance.GameOver && gamemanager.instance.Playerentered){
            if (Input.GetMouseButtonDown(0))
            {
                ani.Play("jump");
                rb.useGravity = true;
                jump = true;
                gamemanager.instance.playerstarted();


            }

        }
        

    }
    private void FixedUpdate()
    {
        if (jump == true)
        {
            rb.AddForce(new Vector2(0,100f), ForceMode.Impulse);
            rb.velocity = new Vector3(0, 0, 0);
            jump = false;
                        
        }

        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hit")
        {
            rb.AddForce(new Vector2(80, 40), ForceMode.Impulse);
            
            rb.detectCollisions = false;
            gamemanager.instance.playercollided();
        }
    }
}
