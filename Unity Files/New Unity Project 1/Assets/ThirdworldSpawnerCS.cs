using UnityEngine;
using System.Collections;

public class ThirdworldSpawnerCS : MonoBehaviour {

	
	public GameObject Collectable;
	public Vector3 spawn_position;
	public double timer = 0.0;
	public GameObject temp_spawn_cube;

	public int sRandom;
	// Use this for initialization
	void Start () {
	
	}

	void spawn_Collectable ()
	{

		spawn_position.x = Random.Range(-39.5f, -159.5f);
		spawn_position.y = -95.7693f;
		spawn_position.z = Random.Range(-90f, 85.5f); 
		GameObject temp_spawn_cube = (GameObject)Instantiate(Collectable, spawn_position, transform.rotation);
		//GameObject go = (GameObject)Instantiate(Resources.Load(Collectable)); ;
	}

	
	// Update is called once per frame
	void Update () {
		sRandom = Random.Range(15,25);
		if(pauseWorld.paused == false){
		timer += Time.deltaTime;
			if(timer > sRandom)
		{
			spawn_Collectable();
			timer = 0.0;
		}
	}
	}
}
