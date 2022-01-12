using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	public Text timerText;
	public Text ballsCounter;
	public AudioClip ballInPocketSound;
	public AudioSource clockSound;

	[SerializeField][Range(0, 300)]
	private float timer = 120;

	private int ballsCount = 0;


	void Start () 
	{
		timer -= Score.level;
	}
	

	void Update () 
	{
		timerText.text = Mathf.Ceil(timer).ToString();
		ballsCounter.text = ballsCount.ToString() + "/15";
		timer -= Time.deltaTime;

		if (timer <= 0)
			Restart(); 

		
		clockSound.volume = 1 - Mathf.Clamp01(timer/20f);
	}

	public void Restart () 
	{	
		Score.level = 0;
		Score.score = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );	
	}


	public void NextLevel()
	{
		Score.level++;
		Score.score += Mathf.FloorToInt(timer);
		if (SceneManager.GetActiveScene().buildIndex + 1 <= 4)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		else
		{
			SceneManager.LoadScene(0);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player")
		{
			ballsCount++;
			timer += 20f; 
			Destroy(other.gameObject);
			AudioSource.PlayClipAtPoint(ballInPocketSound, other.transform.position,  1f);

			if (ballsCount >= 15)
			NextLevel ();
		}
	}
}
