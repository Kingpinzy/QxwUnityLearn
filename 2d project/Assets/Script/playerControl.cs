using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D songshu;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();      
    }
    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");
        float faceorientation = Input.GetAxisRaw("Horizontal");
        songshu.velocity = new Vector2(horizontalmove * speed * Time.deltaTime, songshu.velocity.y);

        if (horizontalmove != 0) 
        { 
            songshu.velocity = new Vector2(horizontalmove * speed*Time.deltaTime, songshu.velocity.y);
        }
        if (faceorientation != 0)
        {
            transform.localScale = new Vector3(faceorientation, 1, 1);
        }
        
    }

       
    
    
}
