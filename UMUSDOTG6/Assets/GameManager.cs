using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0,0);
        score = 0;
        UpdateScore();
        StartCoroutine("UpScore");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        UpdateScore();

    }

    void UpdateScore()
    {
        scoreText.text = "" + score;
    }

    IEnumerator UpScore()
    {
        for (; ; )
        {
            score += 7;
            yield return new WaitForSeconds(.4f);
        }
    }
}
