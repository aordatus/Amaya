using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
	private static int enemies;
		


    void Start ()
    {
		enemies = 0;
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


	void Update ()
	{
		if(enemies >= 50)
			CancelInvoke ("Spawn");
	}

    void Spawn ()
	{
		if (playerHealth.currentHealth <= 0f) {
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		++enemies;

		}
	}

