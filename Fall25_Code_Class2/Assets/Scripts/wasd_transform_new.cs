using UnityEngine;
using UnityEngine.InputSystem;

public class wasd_transform_new : MonoBehaviour
{
    //variables 
    public float speed;

    private Vector3 position;

    public InputActionReference movement;

   

    // Update is called once per frame
    void Update()
    {
        position = movement.action.ReadValue<Vector2>() * speed * Time.deltaTime;
        transform.position += position;
    }

    private void FixedUpdate()
    {
        
    }
}
