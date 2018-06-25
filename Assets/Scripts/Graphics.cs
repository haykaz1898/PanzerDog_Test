using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Graphics : MonoBehaviour {

	// Use this for initialization
	public void Quality(string s){
		GameObject.Find ("GraphicText").GetComponent<Text> ().text = s;
		PlayerPrefs.SetString ("Graphics", s);
	}
	void Start () {
		GameObject.Find ("GraphicText").GetComponent<Text> ().text = PlayerPrefs.GetString ("Graphics");
	}

}
