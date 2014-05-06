#pragma strict

function Start () {

}

  var levelToLoad : String;
   
    
      function OnTriggerEnter ()
    {
  Debug.Log("collide");
    Application.LoadLevel (levelToLoad);
    }