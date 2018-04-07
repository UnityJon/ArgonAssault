using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In m^s-1")] [SerializeField] float xSpeed = 4f;
    [Tooltip("In m")] [SerializeField] float clampXMovement = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawXPos = xOffset + transform.localPosition.x;
        float clampedXPos = Mathf.Clamp(rawXPos, -clampXMovement, clampXMovement);
        transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y, transform.localPosition.z);
	}
}
