using UnityEngine;
using System.Collections;

public class VisionController : MonoBehaviour {
	NightVision nightVision;

	float zoom;
	// Use this for initialization
	void Start () {
		nightVision = FindObjectOfType<NightVision>();
	}


	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1))
			nightVision.enabled = !nightVision.enabled;

		if(nightVision.enabled)
		{
			// Due to practicing shaders and image effects I made zoom effect from shader by changing uv's so this makes your screen a little pixelized
			// It's better to use FOV, so comment out this section if you wish 
			zoom = Mathf.Clamp(zoom+Input.GetAxis("Mouse ScrollWheel"),0f,8f);
			nightVision._Zoom =zoom;
			// use this instead
			//			zoom = Mathf.Clamp(zoom+Input.GetAxis("Mouse ScrollWheel"),1f,4f);
			//			Camera.main.fieldOfView = 60f/zoom;
		}
	}
}
