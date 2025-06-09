using UnityEngine;
using UnityEngine.UI;

public class score_counter : MonoBehaviour
{
    public int player_score;
    public Text score_text;

    public void add_score(int score_to_add)
    {
        player_score = player_score + score_to_add;
        score_text.text = player_score.ToString();
    }
}
