using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Lang : MonoBehaviour {
	public Sprite gb,ru;
	public Text text;

	public void setLanguage(string Language){
		if (Language == "gb") {
			GameObject.Find ("curLang").GetComponent<Image>().sprite = gb;
			text.text = "ENGLISH";
			PlayerPrefs.SetString ("Language", "ENGLISH");
			PlayerPrefs.SetInt ("Flag", 0);
		}
		if (Language == "ru") {
			GameObject.Find ("curLang").GetComponent<Image> ().sprite = ru;
			text.text = "RUSSIAN";
			PlayerPrefs.SetString ("Language", "RUSSIAN");
			PlayerPrefs.SetInt ("Flag", 1);
		}
	}
	void Start(){
		text.text = PlayerPrefs.GetString ("Language");
		if (PlayerPrefs.GetInt ("Flag") == 0) {
			GameObject.Find ("curLang").GetComponent<Image> ().sprite = gb;
		}
		if (PlayerPrefs.GetInt("Flag") == 1){
			GameObject.Find ("curLang").GetComponent<Image> ().sprite = ru;
		}
	}

}
