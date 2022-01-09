using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int level;
	public static int score; 

	public Text levelText;
	public Text scoreText;
	
	void Update () {
		levelText.text = "Level : " + level.ToString();
		scoreText.text = "Score : " + score.ToString();
	}
}
