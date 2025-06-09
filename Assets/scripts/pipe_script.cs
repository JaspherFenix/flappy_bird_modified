using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float movement_speed = 5;

    public float highest = 2.13f;
    public float lowest = -2.07f;
    public float speed = 1f;

    private float amplitude;
    private float centerY;
    private Vector3 startPos;

    private bool isMoving;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;

        centerY = (highest + lowest) / 2f;
        amplitude = (highest - lowest) / 2f;

        isMoving = Random.Range(0, 3) == 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movement_speed) * Time.deltaTime;
        
        if (isMoving)
        {
            moving_pipe();
        }

        if (transform.position.x < -11.13)
        {
            Destroy(gameObject);
            Debug.Log("object deleted");
        }
    }

    // Function for generating moving pipe
    void moving_pipe()
    {
        float newY = centerY + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(transform.position.x, newY, startPos.z);
    }
}
