using UnityEngine;

public class collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




	void OnCollisionEnter (Collision other) {


	if (other.collider.name == "Player") {

		Destroy(this.gameObject);

	}

	


	}
}

