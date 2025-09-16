using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Wasd_transform : MonoBehaviour
{
    //variables
    public float speed;

    private Vector2 position;

    //public InputActionReference movement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

        

       
    }

    // Update is called once per frame
    void Update()
    {
        //vector2 is where we are located every frame
        position = transform.position;

        //press w to go up
        if(Input.GetKey(KeyCode.W))
        {
            position.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.y -= speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            position.x += speed * Time.deltaTime;
        }
        if( Input.GetKey(KeyCode.A))
        {
            position.x -= speed * Time.deltaTime;
        }
        transform.position = position;
    }
}
