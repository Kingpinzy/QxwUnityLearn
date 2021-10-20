using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody2D songshu;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();      
    }
    void Movement()
    {
        float horizontalmove;
        horizontalmove= Input.GetAxis("Horizontal");
        songshu.velocity = new Vector2(horizontalmove * speed, songshu.velocity.y);
    }

       
    
    
}
