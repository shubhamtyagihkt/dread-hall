using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class StageText : MonoBehaviour {
 
    public Text scoreText;  // public if you want to drag your text object in there manually
 
    void Start () {
        scoreText = GetComponent<Text>();  // if you want to reference it by code - tag it if you have several texts
    }
 
    void Update () {
		int scoreCounter = LevelGenerator.stage;
        scoreText.text = "Stage: " + scoreCounter.ToString();  // make it a string to output to the Text object
    }
}