using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpForce = 300f;
    public GameObject title;
    public GameObject title2;

    // Start is called before the first frame update
    void Start()
    {
        rb2d.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(rb2d.isKinematic == true)
            {
                rb2d.isKinematic = false;
                Destroy(title);
                Destroy(title2);
            }
            rb2d.velocity = Vector3.zero;
            rb2d.AddForce(Vector3.up * jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
        }
    }
}
