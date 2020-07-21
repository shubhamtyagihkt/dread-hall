using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class LoadSceneOnInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1) {
			// try playing creepy whisper sound if exists
			// whisper sound is stopped when transitioning to gameover state
			// here we play the sound on transition to play state
			try {
                 DontDestroy.instance.GetComponents<AudioSource>()[0].Play();
            }
            catch ( NullReferenceException e ) {
                Debug.Log(e.Message);
            }
			SceneManager.LoadScene("Play");
		}
	}
}
