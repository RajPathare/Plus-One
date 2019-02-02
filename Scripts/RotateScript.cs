using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

	public float speed = 15f;
	public playerColl coll;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(speed, 0, 0);


		}
		
	}

