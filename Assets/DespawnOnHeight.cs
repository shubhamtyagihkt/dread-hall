using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

	private AudioSource pickupSoundSource;

	void Awake() {
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -0.8) {
			// Stop playing whisper sound when transitioning to gameover state
			DontDestroy.instance.GetComponents<AudioSource>()[0].Stop();
			// same pickup sound is played on gameover
			pickupSoundSource.Play();

			// resetting stage on gameovers
			LevelGenerator.stage = 0;

			SceneManager.LoadScene("GameOver");
		}
	}
}
