using UnityEngine;

public class BlockSpawn : MonoBehaviour {

	public Transform[] spawnPoints;

	public GameObject blockPrefab;


	private float timeToSpawn = 0.5f;

	public float timeBetweenW = 0.001f;

	private Rigidbody rb1;


	void Start() {

		rb1 = GetComponent<Rigidbody>();

	}

	// Use this for initialization
	void Update () 

	{

	 	if(Time.time >= timeToSpawn)
	 	{
	 		SpawnBlocks();
	 		timeToSpawn = Time.time + timeBetweenW;
	 	}

	 	//rb1.AddForce(0,0,6f);
	 	blockSpeed();

	 	}
		


	void blockSpeed () {

		var pos1 = transform.position;

		pos1.z = pos1.z + 0.2f;
		transform.position = pos1;
		

	}
	
	// Update is called once per frame
	void SpawnBlocks () 

	{

		int randomIndex = Random.Range(0, spawnPoints.Length);

		for (int i =0; i < spawnPoints.Length ; i++) 
		{

			if(randomIndex != i)

			{
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
			}

			

		}
		
	}



}
