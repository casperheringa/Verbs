using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    int speed = 40;
    public bool jumping = false;
    public Transform muzzle;
    public GameObject bullet;
    private int counter;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        counter = 0;
    }

    void FixedUpdate()
    {
        if (Time.time > counter)
        {

            }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, muzzle.position, muzzle.rotation);
        }

      //  rb.AddForce(Vector3.down * 13);
        if (jumping == true)
        {
            speed = 20;
        }
        else
        {
            speed = 35;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
            transform.localScale = new Vector3(0.4766933f, 0.4766933f, 0);
            muzzle.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
            transform.localScale = new Vector3(-0.4766933f, 0.4766933f, 1);
            muzzle.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKeyDown(KeyCode.W) && !jumping)
        {
            rb.AddForce(Vector3.up * 600);
            jumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Floor")
        {
            jumping = false;
        }
    }
}
