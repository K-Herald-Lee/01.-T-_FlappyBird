using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Score.scoreBest < Score.score)
        {
            Score.scoreBest = Score.score;
        }
        GetComponent<Text>().text = "Best Score: " + Score.scoreBest.ToString();
    }

}
