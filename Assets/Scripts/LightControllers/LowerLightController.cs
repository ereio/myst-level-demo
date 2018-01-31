/** Author: Taylor Ereio
 * File: LowerLightController.cs
 * Date: 2/26/2015
 * Description: Script changes the lights from an on and off state using the intensity setting
 * Specific to the lower floor lighting
 * */
using UnityEngine;
using System.Collections;

public class LowerLightController : MonoBehaviour {

	GameObject[] lights;

	void Start() {
		// gets the array or list of go's tagged with DownstairsLighting from
		// the start of the game
		lights = GameObject.FindGameObjectsWithTag("DownstairsLighting");
	}


	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider go){
		if(go.name == "First Person Controller"){
			// sets each of the tagged objects light intensity component to 5
			foreach(GameObject roomLight in lights)
				roomLight.GetComponent<Light>().intensity = 5;
		}
	}

	void OnTriggerExit(Collider go){
		if(go.name == "First Person Controller"){
			// sets each of the tagged objects light intensitycomponent to 0
			foreach(GameObject roomLight in lights)
				roomLight.GetComponent<Light>().intensity = 0;
		}
	}
}
