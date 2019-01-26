using UnityEngine;

public class CollectSpawn : MonoBehaviour {


	public Transform[] spawnPoints;

	public GameObject collectPrefab;

	private float timeToSpawn = 0.5f;

	public float timeBetweenW = 0.001f;

	private Rigidbody rb2;


	// Use this for initialization
	void Start () {
		rb2 = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.time >= timeToSpawn)
	 	{
	 		SpawnColl();
	 		timeToSpawn = Time.time + timeBetweenW;
	 	}

	 	//rb1.AddForce(0,0,6f);
	 	collSpeed();
		
	}


	void collSpeed () {

		var pos1 = transform.position;

		//pos1.z = pos1.z + 0.2f;
		pos1.z = pos1.z + 0.2f;
		transform.position = pos1;
		

	}

	// Update is called once per frame
	void SpawnColl () 

	{

		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i =0; i < spawnPoints.Length ; i++) 
		{

			if(randomIndex != i)

			{
				Instantiate(collectPrefab, spawnPoints[i].position, Quaternion.identity);
			}

			

		}
		
	}
}
