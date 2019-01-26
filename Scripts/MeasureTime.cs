using UnityEngine.UI;
using UnityEngine;

public class MeasureTime : MonoBehaviour {


	public Text TimeText;
	public static float realtime = 0f;
	public PlayerMov movement;


	
	public int normtime2 = 0;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		TimeText.text = measTime().ToString();

		
	}


	public float measTime()

	{

		//float realtime = Time.fixedTime;
		float realtime = Time.timeSinceLevelLoad;
		int normtime = (int)realtime;

		if(movement.enabled == false){
			normtime2 = normtime;
			return normtime2;
		}

		else
		return normtime;


		}

	}





