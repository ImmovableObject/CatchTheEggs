using UnityEngine;
using System.Collections;

public class DroppedObject : MonoBehaviour {

	public GameObject Explosion;

	//If collison with basket or deathwall, instantiate Explode prefab then despawn
	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag ==  "Player" || otherObject.tag ==  "DeathWall"){
			Instantiate(Explosion, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}
}