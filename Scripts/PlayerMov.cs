using UnityEngine;


public class PlayerMov : MonoBehaviour {

	/*public Rigidbody rb;

	
	public float sideForce = 500f;


	// Update is called once per frame
	void FixedUpdate () 
	{

		rb.AddForce(0,0, forwardForce*Time.deltaTime);

		if(Input.GetKey("d"))

		{
			rb.AddForce(sideForce*Time.deltaTime,0,0);
		}

		if(Input.GetKey("a"))

		{
			rb.AddForce(-sideForce*Time.deltaTime,0,0);
		}



		
	}*/

	public float speed = 15f;
	public float mapWidth = 4.5f;

	private Rigidbody rb;


	void Start () 
	{

		rb = GetComponent<Rigidbody>();

	}

	void Update () {


		var pos = transform.position;

		//var rot = transform.rotation;

		//pos.z = pos.z + 0.2f;
		//transform.position = pos;

		
		pos.z = pos.z + 0.2f;
		transform.position = pos;

		/*if(Time.time>=10){

		pos.z = pos.z + 0.25f;
		transform.position = pos;
		}*/
		

		

		/*rot.x = rot.x + 0.2f;
		transform.rotation = rot;*/
		

	}

	void FixedUpdate()

	{	


		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

		Vector3 newPosition = rb.position + Vector3.right * x;

		newPosition.x = Mathf.Clamp(newPosition.x, - mapWidth, mapWidth);

		rb.MovePosition(newPosition);



	}


}
