using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    Text text;
    int oldScore;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        text = GetComponentInChildren<Text>();
        oldScore = gameManager.score;
        text.text = "Score: " + gameManager.score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        //text.text = "Score: " + gameManager.score.ToString(); //Apply only when score changes
        if (oldScore != gameManager.score)
        {
            text.text = "Score: " + gameManager.score.ToString();
            oldScore = gameManager.score;
        }
    }
}
