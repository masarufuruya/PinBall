using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//フリッパー機能用クラス
public class FripperController : MonoBehaviour {
	HingeJoint myHingeJoint;
	//初期の傾き
	float defaultAngle = 20;
	//弾いた時の傾き
	float flickAngle = -20;

	//ゲームオブジェクト毎の初期化を行う
	void Awake() {
		//HinjiJointコンポーネント取得
		this.myHingeJoint = GetComponent<HingeJoint>();
		//フリッパーの傾きを設定
		SetAngle(this.defaultAngle);
	}

	// Update is called once per frame
	void Update () {
		//左やじるキーを押した時フリッパーを動かす
		if (Input.GetKeyDown (KeyCode.LeftArrow) && tag == "LeftFripperTag") {
			SetAngle (this.flickAngle);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow) && tag == "RightFripperTag") {
			SetAngle (this.flickAngle);
		}
		//矢印キー離された時にフリッパーを元に戻す
		if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) {
			SetAngle(this.defaultAngle);
		}
	}

	void SetAngle(float angle) {
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;
	}
}
