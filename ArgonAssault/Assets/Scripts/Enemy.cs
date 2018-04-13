using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathFX;
    [SerializeField] Transform parent;

	// Use this for initialization
	void Start () {
        AddNonTriggerBoxCollider();
	}

   void OnParticleCollision(GameObject other)
    {
        //Instantiate an explosion FX at the enemy's current position.  Assign FX to runtime parent object
        GameObject fx =Instantiate(deathFX, transform.position,Quaternion.identity);
        fx.transform.parent = parent;

        //destroy the enemy itself
        Destroy(gameObject);
    }

    void AddNonTriggerBoxCollider()
    {
        Collider myCollider = gameObject.AddComponent<BoxCollider>();
        myCollider.isTrigger = false;
    }
}
