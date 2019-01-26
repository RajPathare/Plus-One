using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {


	public Text HighScoreText;
	public Text ScoreText;
	public Transform ball;
	int hscore;
	int pos = 0;

	// Use this for initialization
	void Start () {

			HighScoreText.text = PlayerPrefs.GetInt("hscoreValue").ToString();
	}
	
	// Update is called once per frame
	void Update () {

		checkScore();

		
	}


	public void checkScore() {


	if(int.Parse(ScoreText.text) > int.Parse(HighScoreText.text)){

			//hscore = (int)ball.position.z;
			hscore = int.Parse(ScoreText.text);
			PlayerPrefs.SetInt("hscoreValue", hscore);	
			

		}

	}
}

