using UnityEngine;
using System.Collections;

public class MenuHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickButton(){
	
		Debug.Log ("ClickButton()");
	}

	public void ToggleButton(bool isOn){

		Debug.Log ("TaggelButton(bool isOn)" + isOn);
	}
}

