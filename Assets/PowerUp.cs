using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {

	public Text getem;
	public Text getit;

	public int multiplier = 20;


	public GameObject pickupEffect;

	public bool buy = false;




	void OnTriggerEnter (Collider other)
	{
		

		if (other.CompareTag("Player"))
		{
			
			if (buy == true) {
				Pickup (other);
				Destroy (getit);
					  


			} 
			else 
			{
				getem.text = "Get 200 Emeralds";

			}


			 
			}
	}
	void Pickup(Collider player)
    {
		Instantiate (pickupEffect, transform.position, transform.rotation);

		PlayerHealth stats = player.GetComponent<PlayerHealth> ();
		stats.currentHealth *= multiplier;
		stats.healthSlider.maxValue *= multiplier;

		Destroy(gameObject);


	}
}
