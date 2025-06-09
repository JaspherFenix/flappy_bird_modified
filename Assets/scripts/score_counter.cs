using UnityEngine;
using UnityEngine.UI;

public class score_counter : MonoBehaviour
{
    public int player_score;
    public Text score_text;

    public void add_score()
    {
        player_score = player_score + 1;
        score_text.text = player_score.ToString();
    }
}
