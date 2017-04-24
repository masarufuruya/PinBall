using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	float visiblePosZ = -6.5f;
	GameObject gameoverText;

	void Awake() {
		//テキストを取得
		this.gameoverText = GameObject.Find ("GameOverText");
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.z < this.visiblePosZ) {
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}
}
