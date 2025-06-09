using UnityEngine;

public class texts_script : MonoBehaviour
{
    public float movement_speed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movement_speed) * Time.deltaTime;

        if (transform.position.x < -18.13)
        {
            Destroy(gameObject);
        }
    }
}
