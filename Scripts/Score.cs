using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {


	public Text scoreText;
	public Text HighScoreText;
	public Transform player;
	public int highScore = 0;

	
	// Update is called once per frame

	


	void Update () {
		
		scoreText.text = player.position.z.ToString("0");



	}



}
