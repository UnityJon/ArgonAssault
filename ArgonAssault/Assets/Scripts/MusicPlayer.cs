﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    private void Awake()
    {
        int numMusicPlayers=FindObjectsOfType<MusicPlayer>().Length;
        if (numMusicPlayers>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start ()
    {
 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
