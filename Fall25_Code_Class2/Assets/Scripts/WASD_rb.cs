using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_rb : MonoBehaviour
{
    //Variables
    public Rigidbody2D rb;
    public float forceamount = 2.5f;
  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //attach the rigidbody2d from this object to the script as rb
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //make the square move up if I press w
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceamount);
        }
        //make the square move right if i press d
        if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector2.right * forceamount);
        }
        //make the square move left if i press a
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceamount);
        }
        //make the square move down if i press s
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceamount);
        }
    }
}
