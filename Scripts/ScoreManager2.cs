/*using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
	
	public Text ScoreText;
	private int count=0;

	
	// Update is called once per frame
	void Update ()
	{

		ScoreText.text = getCount().ToString();

	}


	void OnCollisionEnter(Collision collisionInfo){

	
		if(collisionInfo.collider.tag == "Obstacle"){

			count = count - 5;

		}

		else if(collisionInfo.collider.tag == "Collect"){

			count++;

		}


	}



	
}
*/