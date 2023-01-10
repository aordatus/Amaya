using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamewinning : MonoBehaviour {


	public bool donewon = false;

	Gamewinning gamewinning;

	Animator anim;


	void OnTriggerEnter()
	{
		donewon = true;

	}
}
