using UnityEngine.UI;
using UnityEngine;

public class playerColl : MonoBehaviour {


	public PlayerMov movement;
	public Text ScoreText;
	public GameObject GameOverBoard;
	public GameObject Time;
	public GameObject ongoingGame;

	private int count=0;

	void Update () {


		ScoreText.text = getCount().ToString();


	}


	
	void OnCollisionEnter (Collision collisionInfo) 

	{
		if(collisionInfo.collider.tag == "Obstacle")
		{

			count = count - 5;

		}

		else if(collisionInfo.collider.tag == "Collect")
		{

			count++;

		}

		if(count < 0){

		movement.enabled = false;
		GameOverBoard.SetActive(true);
		ongoingGame.SetActive(false);
		Time.SetActive(false);
		count = 0;
		
	}

	}


	public int getCount () {


		return count;
	}

	


}