using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	//総合得点(publicで別クラスに公開する)
	public int totalScore = 0;
	Text scoreText;

	void Awake() {
		this.scoreText = GameObject.FindWithTag ("ScoreTextTag").GetComponent<Text> ();
		//初回表示
		this.setScoreText ();
	}
		
	void setScoreText() {
		this.scoreText.text = "得点: " + this.totalScore;
	}

	//当たった物体に応じて得点を加算する
	public void addScore(string collisionObjTag) {
		//小さい星の時は10点加算
		if (collisionObjTag == "SmallStarTag") {
			this.totalScore += 10;
		} else if (collisionObjTag == "LargeStarTag" || collisionObjTag == "SmallCloudTag") {
			//大きい星と小さい雲の時は20点加算
			this.totalScore += 20;
		} else if (collisionObjTag == "LargeCloudTag") {
			//大きい雲は30点加算
			this.totalScore += 30;
		}
		//加算後の得点で更新
		this.setScoreText ();
	}
}
