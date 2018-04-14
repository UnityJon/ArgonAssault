using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;
    [SerializeField] int scorePerKill = 12;
    [SerializeField] int health=2;

    ScoreBoard scoreBoard;

	// Use this for initialization
	void Start () {
        AddNonTriggerBoxCollider();
        scoreBoard = FindObjectOfType<ScoreBoard>();
	}

   void OnParticleCollision(GameObject other)
    {
        health--;
        scoreBoard.ScoreHit(1);
        if (health < 1)
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        //Instantiate an explosion FX at the enemy's current position.  Assign FX to runtime parent object
        GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
        fx.transform.parent = parent;

        //Increase Score
        scoreBoard.ScoreHit(scorePerKill);

        //destroy the enemy itself
        Destroy(gameObject);
    }

    void AddNonTriggerBoxCollider()
    {
        Collider myCollider = gameObject.AddComponent<BoxCollider>();
        myCollider.isTrigger = false;
    }
}
