#pragma strict

var Collectable : GameObject;
var spawn_position;
var timer = 0.0;

function spawn_Collectable ()
{
spawn_position = Vector3 (Random.Range(-22, 7.5),-4.5,Random.Range(-21, 26.5)) ;
var temp_spawn_cube = Instantiate(Collectable, spawn_position, Quaternion.identity);
}

function Start () {

}

function Update () {
timer += Time.deltaTime;
if(timer > 10)
{
spawn_Collectable();
timer = 0.0;
}
}