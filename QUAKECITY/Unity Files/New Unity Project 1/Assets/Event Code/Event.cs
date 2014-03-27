using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {
	
	public GameObject[] prefabToSpawn;
	public int spawner;
	public Vector3 spawnLocation = new Vector3 (0,0,0);
	public bool onetime = false;
	int ii = 0;
	// Use this for initialization
	void Start () {	
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if(onetime == true){
			ii++;
			if(ii>100){
				onetime = false;
				ii = 0;
			}
		}

	
		if ((StatsCode.minutes == 9) && (StatsCode.seconds == 15))
		{
			if(onetime == false){
	
				SpawnEvent();
				onetime = true;
			}
			
		}

		if ((StatsCode.minutes == 8) && (StatsCode.seconds == 30))
		{
			
			if(onetime == false){
				
				SpawnEvent();
				onetime = true;
			}

			
		}

		if ((StatsCode.minutes == 7) && (StatsCode.seconds == 15))
		{
			
			if(onetime == false){
				
				SpawnEvent();
				onetime = true;
			}
			
		}
	}
	
	void SpawnEvent () {					//Creates a chosen object at chosen location when called
	spawner = Random.Range (0,11);
   	Instantiate(prefabToSpawn[spawner], spawnLocation, Quaternion.identity );
	}
}
