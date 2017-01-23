using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {

	float yPos;
	public GameObject Counter;
	
	void Awake(){yPos = transform.position.y;}

	//Move towards mouse position every frame and lock the y position
	void Update (){
		Vector3 pos = new Vector3(Input.mousePosition.x,yPos,transform.position.z - Camera.main.transform.position.z);
		transform.position = Camera.main.ScreenToWorldPoint(pos);
		
		if (transform.position.x <= -8.4f){transform.position = new Vector3(-8.4f, transform.position.y, transform.position.z);}
		if (transform.position.x >= 8.4f){transform.position = new Vector3(8.4f, transform.position.y, transform.position.z);}
	}
	
	//If collision with egg, add score to ScoreCounter.CurrentScore
	//If collision with bomb, subtract score to ScoreCounter.CurrentScore
	
	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag ==  "Egg"){
			Counter.GetComponent<ScoreCounter>().ChangeScore(100);
		}
		
		if (otherObject.tag ==  "Bomb"){
			Counter.GetComponent<ScoreCounter>().ChangeScore(-100);
		}
	}
}