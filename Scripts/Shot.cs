using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	//プレファブ化した弾
	public GameObject bullet;
	//プレファブ化したボム
	public GameObject bom;

	//発射先
	private GameObject gun;

	//弾を撃つためのインターバル
	private float shotInterval = 0f;
	private float shotIntervalMax = 0.2f;

	//ボムを投げるためのインターバル
	private float bomInterval = 0f;
	private float bomIntervalMax = 1.0f;

	// Use this for initialization
	void Start () {
		//発射先の取得
		gun = GameObject.Find ("GunBarrelEnd");	
	}
	
	// Update is called once per frame
	void Update () {
		//インターバル時間をプラス
		shotInterval += Time.deltaTime;
		bomInterval += Time.deltaTime;

		//左クリックを押した時弾を発射
		if (Input.GetMouseButton (0)) {
			if (shotInterval > shotIntervalMax) {
				Instantiate (bullet, gun.transform.position, transform.rotation);
				shotInterval = 0f;
			}
		}

		//右クリックを押した時ボムを投擲
		if (Input.GetMouseButton (1)) {
			if (bomInterval > bomIntervalMax) {
				Instantiate (bom, gun.transform.position + new Vector3(0, 1f, 0), transform.rotation);
				bomInterval = 0f;
			}
		}
	}
}
