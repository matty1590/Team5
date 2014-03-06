using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {
	
	public GameObject[] prefabToSpawn;
	public int spawner;
	public Vector3 spawnLocation = new Vector3 (0,0,0);
	
	
	// Use this for initialization
	void Start () {	
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if ((StatsCode.minutes == 7) && (StatsCode.seconds == 0))
		{
	
		SpawnEvent();
			
		}

		if ((StatsCode.minutes == 4) && (StatsCode.seconds == 0))
		{
			
			SpawnEvent();
			
		}

		if ((StatsCode.minutes == 1) && (StatsCode.seconds == 0))
		{
			
			SpawnEvent();
			
		}
	}
	
	void SpawnEvent () {					//Creates a chosen object at chosen location when called
	spawner = Random.Range (0,11);
   	Instantiate(prefabToSpawn[spawner], spawnLocation, Quaternion.identity );
	}
}
