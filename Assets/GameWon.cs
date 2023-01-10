using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameWon : MonoBehaviour {

	public GameObject endpoint;

	Gamewinning gamewinning;

	public float gDelay = 3f;

	public Animator anim;

	void Awake ()
	{
		gamewinning = endpoint.GetComponent <Gamewinning> ();

	}


	void Update ()
	{
		if (gamewinning.donewon == true) {
			anim.SetTrigger("Gamewon");
			Invoke ("LoadNextLevel", gDelay);
		}
	}

	public void LoadNextLevel()
	{
		SceneManager.LoadScene ("Menu");

	}
}
