using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ToggleHelper : MonoBehaviour {
	 
	InputField field;

	// Use this for initialization
	void Start () {

		field = GameObject.FindObjectOfType<InputField> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnChenged(bool isOn){
	
		if(isOn){

			field.text = gameObject.name;
		}
	}
}
