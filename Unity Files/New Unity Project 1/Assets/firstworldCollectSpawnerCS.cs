using UnityEngine;
using System.Collections;

public class firstworldCollectSpawnerCS : MonoBehaviour {
	
	
	public GameObject Collectable;
	public Vector3 spawn_position;
	public double timer = 0.0;
	//public GameObject temp_spawn_cube;
	// Use this for initialization
	void Start () {
		
	}
	
	void spawn_Collectable ()
	{

		spawn_position.x = Random.Range(-4.5f, 4.5f);
		spawn_position.y = -4.7f;
		spawn_position.z = Random.Range(-4.5f, 4.5f); 
		GameObject temp_spawn_cube = (GameObject)Instantiate(Collectable, spawn_position, transform.rotation);
		//GameObject go = (GameObject)Instantiate(Resources.Load(Collectable)); ;
	}
	
	
	// Update is called once per frame
	void Update () {
		if(pauseWorld.paused == false){
		timer += Time.deltaTime;
		if(timer > 10)
		{
			spawn_Collectable();
			timer = 0.0;
		}

		}
	}
}
