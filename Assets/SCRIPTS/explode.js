#pragma strict



function Start () 
{
WaitAndDestroy();
}

function Update () {

}
var explosion : GameObject;
var delay = 3.0; //This implies a delay of 2 seconds.

	function WaitAndDestroy()
	{
		yield WaitForSeconds(delay);
	Instantiate(explosion, transform.position, transform.rotation);
		Destroy (gameObject);
	}