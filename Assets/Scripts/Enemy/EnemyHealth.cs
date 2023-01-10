using UnityEngine;


public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int currentHealth;
	public float sinkSpeed = 2.5f;
	public int scoreValue = 1;
	public AudioClip deathClip;


	AudioSource enemyAudio;
	ParticleSystem hitParticles;
	CapsuleCollider capsuleCollider;

	bool isDead;
	bool isSinking;

	void Awake ()
	{
		
		enemyAudio = GetComponent <AudioSource> ();
		hitParticles = GetComponentInChildren <ParticleSystem> ();
		capsuleCollider = GetComponent <CapsuleCollider> ();

		currentHealth = startingHealth;
	}


	void Update ()
	{
		if(isSinking)
		{
			transform.Translate (-Vector3.up * sinkSpeed * Time.deltaTime);

		}


	}


	public void TakeDamage (int amount, Vector3 hitPoint)
	{
		if(isDead)
			return;

		enemyAudio.Play ();

		currentHealth -= amount;

		hitParticles.transform.position = hitPoint;
		hitParticles.Play();

		if(currentHealth <= 0)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;


		capsuleCollider.isTrigger = true;
		enemyAudio.clip = deathClip;
		enemyAudio.Play ();
		StartSinking ();
		GameObject.Find ("Score").GetComponent<ScoreManager> ().scored = true;
	}


	public void StartSinking ()
	{
		GetComponent <UnityEngine.AI.NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		isSinking = true;
		ScoreManager.score += scoreValue;
		Destroy (gameObject, 2f);
	}
}
