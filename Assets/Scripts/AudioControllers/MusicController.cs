/** Author: Taylor Ereio
 * File: MusicController.cs
 * Date: 2/26/2015
 * Description: Script uses the volume setting of the music to fade the music in and out. Once the volume
 * is so low it's practically inaudiable, it will stop the audio.
 * */

using UnityEngine;
using System.Collections;

public class MusicController: MonoBehaviour {
	bool triggerType = false;
	float fadeInAmt = 0.001f;
	float fadeOutAmt = 0.002f;
	float fadeMax = 5;
	float fadeMin = 0.005f;

	void Update(){
		// if the audio is playing
		// perform an action on triggerType
		if(GetComponent<AudioSource>().isPlaying)
			if(triggerType)
				FadeIn ();
			else
				FadeOut ();
	}

	void OnTriggerEnter(Collider go){
		if(go.name == "First Person Controller"){
			// trigger a fade event and start music at
			// volume zero
			triggerType = true;
			GetComponent<AudioSource>().Play();
			GetComponent<AudioSource>().volume = 0;
		}
	}

	void OnTriggerExit(Collider go){
		if(go.name == "First Person Controller")
			// trigger fade out
			triggerType = false;
	}

	void FadeIn(){
		// increment volume by fadeInAmt till it reaches
		// fade max
			if(GetComponent<AudioSource>().volume < fadeMax)
				GetComponent<AudioSource>().volume += fadeInAmt;
	}


	void FadeOut(){
		// if the audio volume is lower than min
		// just shut it off, otherwise decrement audio
			if(GetComponent<AudioSource>().volume > fadeMin) 
				GetComponent<AudioSource>().volume -= fadeOutAmt;
			else
				GetComponent<AudioSource>().Stop();
		
	}
}
