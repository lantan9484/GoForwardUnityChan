using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	//キューブの移動速度
	private float speed = -0.2f;
	//消滅位置
	private float deadline = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate(this.speed,0,0);
		//画面外に出たら破棄する
		if(transform.position.x < this.deadline){
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D other){
		//Debug.Log("collision2D呼びだし");

		//衝突先がブロックor地面だった時音を鳴らす
		if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag") {
			//Debug.Log ("if呼び出し");
			AudioSource blocksound = gameObject.GetComponent<AudioSource> ();
			blocksound.Play();
		}
	}
}
