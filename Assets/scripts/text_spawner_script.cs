using UnityEngine;

public class text_spawner_script : MonoBehaviour
{
    public GameObject texts;

    public float starting_position_x = -0.3044f;

    public float spawn_rate = 10;
    private float time = 0;

    private bool first = false;

    void Start()
    {
        Instantiate(texts, new Vector3(starting_position_x, transform.position.y, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (!first) spawn_text(); first = true;

        if (time < spawn_rate)
        {
            time = time + Time.deltaTime;
        }
        else 
        {
            spawn_text();
            time = 0;

        } 
    }

    void spawn_text()
    {

       Instantiate(texts, transform.position, transform.rotation);
        
    }
}
