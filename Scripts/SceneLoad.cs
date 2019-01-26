using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneLoad : MonoBehaviour {


	public MeasureTime MeasureTime;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void StartGame(){


		
		SceneManager.LoadScene("MainGame");

	}

	public void menu(){

		SceneManager.LoadScene("MainMenu");


	}

	public void QuitGame() {

		Application.Quit();

	}
}
