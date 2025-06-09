using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class invisible_middle_pipe_script : MonoBehaviour
{
    public score_counter logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("score_counter").GetComponent<score_counter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.add_score();
    }
}
