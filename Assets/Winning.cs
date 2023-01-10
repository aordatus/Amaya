
using UnityEngine;

public class Winning : MonoBehaviour {

	public GameOverManager gom;

	public bool gamewon = false;

	void OnTriggerEnter ()
	{
		gamewon = true;
	}
}
