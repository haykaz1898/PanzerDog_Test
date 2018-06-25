using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Audio : MonoBehaviour {
	public bool musicStatus, soundStatus;
	public Sprite musicOff,musicOn,soundOff,soundOn;
	public Text musicText;
	public Text soundText;
	// Use this for initialization

	private void AudioSettings(string s,bool status,Sprite On,Sprite Off,Text text){
		if (status) {
			GameObject.Find (s).GetComponent<Image> ().sprite = On;	
			text.text = s.ToUpper () + " ON";
			//GameObject.(s).GetComponent<Text> ().text = text.text;

		} else {
			GameObject.Find (s).GetComponent<Image> ().sprite = Off;
			text.text = s.ToUpper () + " OFF";
			//GameObject.FindGameObjectWithTag(s).GetComponent<Text>().text = text.text;

		}					
	}
	public void setAudioSettings(int i){
		if (i == 0) {
			musicStatus = !musicStatus;

			AudioSettings ("music", musicStatus, musicOn, musicOff, musicText);
			PlayerPrefs.SetInt ("musicStatus", musicStatus ? 1 : 0);
		}
		if (i == 1) {
			soundStatus = !soundStatus;
			AudioSettings ("sound", soundStatus, soundOn, soundOff, soundText);
			PlayerPrefs.SetInt ("soundStatus", soundStatus ? 1: 0);
		}

	}
	void Start () {
		AudioSettings("music", PlayerPrefs.GetInt ("musicStatus") == 1 ? true : false,musicOn,musicOff,musicText);
		AudioSettings ("sound", PlayerPrefs.GetInt ("soundStatus") == 1 ? true : false, soundOn, soundOff, soundText);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
