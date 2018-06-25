using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {
	private List<GameObject> settingList;
	private int index = -1;
	private List<bool> status;
	// Use this for initialization
	void Start () {
		settingList = new List<GameObject> ();
		status = new List<bool> ();
		settingList.Add (GameObject.Find ("LangButtons"));
		settingList.Add (GameObject.Find ("AudioButtons"));
		settingList.Add (GameObject.Find ("GraphicButtons"));
		foreach (var i in settingList) {
			i.SetActive (false);
			status.Add (false);
		}
	}

	public void Expand(int index){
		status [index] = !status [index];
		if (this.index != -1) {
			settingList [this.index].SetActive (false);
		}
		settingList [index].SetActive (status[index]);
		this.index = index;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
