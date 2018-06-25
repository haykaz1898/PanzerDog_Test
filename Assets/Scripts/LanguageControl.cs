using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;

public class LanguageControl : MonoBehaviour {

//	public class Language{
//		private Dictionary<string,Language> dictionary;
//		private XmlDocument xml;
//		public void Load(){
//			xml = new XmlDocument ();
//			xml.Load ("languages.xml");
//		}
//		public void setLang(string language){
//			foreach (XmlNode languages in xml.DocumentElement) {
//				string s = languages.Attributes [0].Value;
//				}
//
//			string element = xml.DocumentElement.Value;
//		}
//	}
	Text buttonText;

	public void onButtonClick(string language){
		//	if(language == rus) 
			// set image
		buttonText.text = "Language:\n" + language; 
		PlayerPrefs.SetString ("Lang", buttonText.text);
	}

	void Start () {
		buttonText = GameObject.Find("LangText").GetComponent<Text>();
		buttonText.text = PlayerPrefs.GetString ("Lang");

	}
	
	void Update () {
		
	}
}
