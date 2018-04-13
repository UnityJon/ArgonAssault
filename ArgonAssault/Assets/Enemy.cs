using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AddNonTriggerBoxCollider();
	}

   void OnParticleCollision(GameObject other)
    {
        print("Enemy "+gameObject.name + "has been shot!");
        Destroy(gameObject);
    }

    void AddNonTriggerBoxCollider()
    {
        Collider myCollider = gameObject.AddComponent<BoxCollider>();
        myCollider.isTrigger = false;
    }
}
