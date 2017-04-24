using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

	// 回転速度
	private float rotSpeed = 1.5f;
	private ScoreManager scoreManager;

	void Awake() {
		if (tag == "LargeStarTag") {
			this.transform.Rotate (0, Random.Range (0, 360), 0);
		}
		scoreManager = GameObject.FindWithTag ("ScoreManagerTag").GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (tag == "LargeStarTag") {
			this.transform.Rotate (0, this.rotSpeed, 0);
		}
	}
		
	void OnCollisionEnter() {
		scoreManager.addScore (this.gameObject.tag);
	}
}
