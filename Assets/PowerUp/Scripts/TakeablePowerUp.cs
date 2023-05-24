using UnityEngine;
using System.Collections;

public class TakeablePowerUp : MonoBehaviour {
	CustomizablePowerUp customPowerUp;

	void Start() {
		customPowerUp = (CustomizablePowerUp)transform.parent.gameObject.GetComponent<CustomizablePowerUp>();
		//this.audio.clip = customPowerUp.pickUpSound;
	}

	void OnCollisionEnter (Collision collider) {
		Debug.Log("Collision");
		if(collider.gameObject.tag == "Player") {
			/*
			PowerUpManager.Instance.Add(customPowerUp);
			if(customPowerUp.pickUpSound != null){
				AudioSource.PlayClipAtPoint(customPowerUp.pickUpSound, transform.position);
			}*/
			Destroy(transform.parent.gameObject);
		}
	}
}
