using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        print("Collided");
    }

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
        print("Player Dying");
        SendMessage("OnPlayerDeath");
    }
}
