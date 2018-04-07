using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In m^s-1")] [SerializeField] float xSpeed = 4f;
    float xOffset = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        xOffset += xThrow * xSpeed * Time.deltaTime;
        print(xOffset);
	}
}
