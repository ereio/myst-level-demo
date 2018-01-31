/** Author: Taylor Ereio
 * File: UpperLightController.cs
 * Date: 2/26/2015
 * Description: Script changes the lights from an on and off state using the intensity setting
 * Specific to the upper floor lighting
 * */
using UnityEngine;
using System.Collections;

public class UpperLightController : MonoBehaviour {

	GameObject[] lights;

	void Start() {
		// gets the array or list of go's tagged with DownstairsLighting from
		// the start of the game
		lights = GameObject.FindGameObjectsWithTag("UpstairsLighting");
	}


	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider go){
		if(go.name == "First Person Controller"){
			// sets each of the tagged objects light intensity component
			foreach(GameObject roomLight in lights)
				if(roomLight.name == "Bulb")		
					roomLight.GetComponent<Light>().intensity = 5;	//if it's a bulb, it doesn't need to be 7
				else
					roomLight.GetComponent<Light>().intensity = 7;	//sets the other spotlight components
		}
	}

	void OnTriggerExit(Collider go){
		if(go.name == "First Person Controller"){
			// sets each of the tagged objects light intensity component to 0
			foreach(GameObject roomLight in lights)
				roomLight.GetComponent<Light>().intensity = 0;
		}
	}
}
