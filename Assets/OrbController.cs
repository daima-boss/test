using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //自分が右にいる？
        if(transform.position.x > 0)
        {
            //左に進む
            rb2d.velocity = Vector3.left * speed;
        }
        else
        {
            //右に進む
            rb2d.velocity = Vector3.right * speed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
