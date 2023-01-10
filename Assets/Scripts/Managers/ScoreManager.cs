using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
	public Image scoreImage;
	public float flashSpeed = 2f;
	public Color flashColour = new Color(2f, 0f, 0f, 0.1f);
	public bool scored;
	public bool sreq;
	public bool cut = false;
	public Text getit;
	public Text getem;

    Text text;


    void Awake ()
    {
		text = GetComponent <Text> 	();
        score = 100;
		sreq = false; 

    }


    void Update ()
	{
		if (scored) {
			scoreImage.color = flashColour;
		} else {
			scoreImage.color = Color.Lerp (scoreImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		scored = false;

		text.text = "Emeralds: " + score;


		if (score >= 200) {
			//Can Buy
			GameObject.Find ("health").GetComponent<PowerUp> ().buy = true; 
			Destroy (getem);
			getit.text = "Get the Powerup";
			Destroy (text);

		}




	


	}
}


