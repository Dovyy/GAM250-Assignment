using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private float score = 0.0f;
    public Text scoreText;
    public Text highscoreText;


    private bool isDead = false;
	// Use this for initialization
	void Start () {
        highscoreText.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead)
            return;

        score += Time.deltaTime;
        scoreText.text = ((int)score).ToString ();
    }

    public void OnDeath()
    {
        isDead = true;
        if(PlayerPrefs.GetFloat("Highscore") < score)
        PlayerPrefs.SetFloat("Highscore", score);
    }
}
