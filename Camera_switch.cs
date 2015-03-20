using UnityEngine;
using System.Collections;


public class Camera_switch : MonoBehaviour {

	public Camera MainCamera;
	public Camera Camera_side;
	public Camera Camera_ground;

	// Use this for initialization
	void Start () {
		MainCamera.enabled = true;
		Camera_side.enabled = false;
		Camera_ground.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.C)) {
			if (MainCamera.enabled == true)
			{
				MainCamera.enabled = false;
				Camera_side.enabled = true;
				Camera_ground.enabled = false;
			} 
			else if (Camera_side.enabled == true)
			{
				MainCamera.enabled = false;
				Camera_side.enabled = false;
				Camera_ground.enabled = true;
			}
			else
			{
				MainCamera.enabled = true;
				Camera_side.enabled = false;
				Camera_ground.enabled = false;
			}
		}
	
	}
}
