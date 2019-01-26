using UnityEngine;

public class Surrounding : MonoBehaviour {

	public GameObject SurrPrefab;

	private Rigidbody rb1;


	// Use this for initialization
	void Start () {
		rb1 = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

	 	collSpeed();
		
	}


	void collSpeed () {

		var pos1 = transform.position;

		//pos1.z = pos1.z + 0.2f;
		pos1.z = pos1.z + 0.13f;
		transform.position = pos1;
		

	}

	// Update is called once per frame
	
		
	
}
