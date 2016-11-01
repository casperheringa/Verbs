using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public Animator anim;
    Rigidbody2D rb;
    public int speed = 15;
    public bool jumping = false;
    public Transform muzzle;
    public GameObject bullet;
    private float counter;
    public float delay;
    public float velocity;
    Vector3 pre;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        counter = 0;
    }

    void FixedUpdate()
    {

        velocity = (transform.position - pre).magnitude / Time.deltaTime;
        pre = transform.position;
        anim.SetFloat("Speed", velocity);

        if (Time.time > counter)
        {
            counter = Time.time + delay;
            Debug.Log(counter);
            }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, muzzle.position, muzzle.rotation);
            anim.SetTrigger("Shoot");

        }

        //  rb.AddForce(Vector3.down * 13);
        if (jumping == true)
        {
            speed = 15;
        }
        else
        {
            speed = 15;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
            //transform.localScale = new Vector3(0.4766933f, 0.4766933f, 0);
            muzzle.rotation = Quaternion.Euler(0, 0, -90);
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
            //transform.localScale = new Vector3(-0.4766933f, 0.4766933f, 1);
            muzzle.rotation = Quaternion.Euler(0, 0, 90);
            transform.rotation = Quaternion.Euler(0, 180, 0);
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
