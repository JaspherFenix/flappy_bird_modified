using UnityEngine;

public class bounce_element_script : MonoBehaviour
{
    public Rigidbody2D jump_element_rigid_body;
    public float jump_height = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump_element_rigid_body.linearVelocity = Vector2.up * jump_height;
        }
    }
}
