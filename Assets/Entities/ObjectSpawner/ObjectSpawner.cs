using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	public float SpawnRate;
	public GameObject Egg;
	public GameObject Bomb;
	private int MovementDirection = 1;
	public float MovementSpeed;
	
	//Start moving the position of object left when the scene starts
	void Start(){
		StartCoroutine(WaitToSpawnObject());
	 }
	void Update(){
		if(MovementDirection == 1){transform.Translate(Vector3.left * MovementSpeed, Space.World);}
		if(MovementDirection == 2){transform.Translate(Vector3.right * MovementSpeed, Space.World);}
	}
	
	//Every X seconds spawn either a Bomb or an Egg
	IEnumerator WaitToSpawnObject(){
		yield return new WaitForSeconds(SpawnRate);
		SpawnRandomObject();
		StartCoroutine(WaitToSpawnObject());
	}
	void SpawnRandomObject(){
		int r = (Random.Range(1,3));
		if(r >= 3){r = 2;}
		
		switch(r){
		case 1:
			Instantiate(Egg, transform.position, Quaternion.identity);
			return;
		case 2:
			Instantiate(Bomb, transform.position, Quaternion.identity);
			return;
		}
		Debug.LogError("Random number out of range: " + r);
	}
	//If collision with bumper wall reverse direction
	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag ==  "Bumper" && MovementDirection == 1){
			MovementDirection = 2;
			return;
		}
		if (otherObject.tag ==  "Bumper" && MovementDirection == 2){
			MovementDirection = 1;
		}
	}
}