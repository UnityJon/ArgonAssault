using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("FX Prefab For Ship")] [SerializeField] GameObject deathFX;
    [Tooltip("In secs")][SerializeField] float levelLoadDelay = 1f;

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
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReloadFirstScene", levelLoadDelay);
    }

    private void ReloadFirstScene () // String referenced
    {
        SceneManager.LoadScene(1);
    }
}
