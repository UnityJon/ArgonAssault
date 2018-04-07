using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

    [Tooltip("In m^s-1")] [SerializeField] float xSpeed = 4f;
    [Tooltip("In m")] [SerializeField] float clampXMovement = 5f;
    [Tooltip("In m^s-1")] [SerializeField] float ySpeed = 4f;
    [Tooltip("In m")] [SerializeField] float clampYMovement = 5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ProcessTranslation();
        ProcessRotation();

    }

    private void ProcessTranslation()
    {
        //Calculate new X Position
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawXPos = xOffset + transform.localPosition.x;
        float clampedXPos = Mathf.Clamp(rawXPos, -clampXMovement, clampXMovement);

        //Calculate new Y Position
        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yOffset = yThrow * ySpeed * Time.deltaTime;
        float rawYPos = yOffset + transform.localPosition.y;
        float clampedYPos = Mathf.Clamp(rawYPos, -clampYMovement, clampYMovement);

        //Update Ship Position
        transform.localPosition = new Vector3(clampedXPos, clampedYPos, transform.localPosition.z);
    }

    private void ProcessRotation()
    {
        transform.localRotation = Quaternion.Euler(-30f,30f,0f);
    }
}
