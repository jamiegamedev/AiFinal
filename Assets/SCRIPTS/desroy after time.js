#pragma strict



function Start () 
{
WaitAndDestroy();
}

function Update () {

}

var delay = 3.0; //This implies a delay of 2 seconds.

	function WaitAndDestroy()
	{
		yield WaitForSeconds(delay);
		Destroy (gameObject);
	}