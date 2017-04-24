using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	//最小サイズ
	float minimum = 1.0f;
	//拡大縮小スピード
	float magSpeed = 9.0f;
	//拡大率
	float magnification = 0.07f;
	ScoreManager scoreManager;

	void Awake() {
		scoreManager = GameObject.FindWithTag ("ScoreManagerTag").GetComponent<ScoreManager> ();
	}

	// Update is called once per frame
	void Update () {
		//雲を拡大縮小(サイズxyz)
		this.transform.localScale = new Vector3(
			//直角三角形 b/c = sinθ(角度に応じて一定だから？) 時間に応じて角度を変えたいから？
			this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification,
			this.transform.localScale.y,
			this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
	}

	void OnCollisionEnter() {
		scoreManager.addScore (this.gameObject.tag);
	}
}
