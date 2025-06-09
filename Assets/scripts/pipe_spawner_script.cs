using UnityEngine;

public class pipe_spawner_script : MonoBehaviour
{
    public GameObject pipe;
    public float spawn_rate = 3;
    private float time = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn_pipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (time < spawn_rate)
        {
            time = time + Time.deltaTime;
        }
        else
        {
            spawn_pipe();
            time = 0;
        }
    }

    void spawn_pipe()
    {
        float highest_point = 2.13f;
        float lowest_point = -2.07f;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest_point, highest_point), 0), transform.rotation);
    }
}
