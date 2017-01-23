using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Deathwall : MonoBehaviour {

	//If collison with egg, load LoseScene
	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag ==  "Egg"){
			SceneManager.LoadScene("LoseScreen");
		}
	}
	
	
	
}