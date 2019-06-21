using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {

	int mp = 53;

	public void Magic(){

		if (this.mp >= 5) {
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {2,3,5,7,11};

		Debug.Log ("配列arrayの各要素を順番に表示します。");
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		Debug.Log ("配列arrayの各要素を逆順に表示します。");
		for (int i = array.Length-1; i >= 0; i--) {
			Debug.Log (array [i]);
		}

		Boss boss = new Boss ();

		Debug.Log ("魔法を使います。");
		for (int i = 1; i <= 11; i++) {
			boss.Magic ();
		}
	
	}

	// Update is called once per frame
	void Update () {
		
	}
}
