 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D songshu;
    public float speed;
    public float jumpforce;
    public Animator Animator;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        //float horizontalmove = Input.GetAxis("Horizontal");
        float faceorientation = Input.GetAxisRaw("Horizontal");
        
        songshu.velocity = new Vector2(faceorientation * speed * Time.deltaTime, songshu.velocity.y);
        Animator.SetFloat("running", Mathf.Abs(faceorientation));
        
        if (faceorientation != 0)
        {
            transform.localScale = new Vector3(faceorientation, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            songshu.velocity = new Vector2(songshu.velocity.x, jumpforce * Time.deltaTime);

        }

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            songshu.velocity = new Vector2(songshu.velocity.x, jumpforce * Time.deltaTime);
            Animator.SetBool("jumping", true);

        }
    }
    




}
