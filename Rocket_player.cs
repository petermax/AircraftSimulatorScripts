using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System;

public class Rocket_player : MonoBehaviour
{
	public int forceY;
	public Text DisplayForceY;
	public Text PositionTextX;
	public float oldPositionY;
	public float oldPositionX;
	public float oldPositionZ;
	public Text PositionTextY;
	public Text PositionTextZ;
	public GameObject Rocket;
	//public StreamWriter sw;
	
	// Use this for initialization
	void Start () {
		//StreamWriter sw = new StreamWriter ("rocket_position.txt");
		PositionTextX.text = "Position X : ";
		PositionTextY.text = "Position Y : ";
		PositionTextZ.text = "Position Z : ";
		DisplayForceY.text = "Force Y : ";
		//sw.WriteLine (DateTime.Now);
		//sw.Close ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		//FileStream fs = new FileStream ("rocket_position.txt", FileMode.Append, FileAccess.Write);
		//StreamWriter sw = new StreamWriter (fs);
		if (Input.GetKeyDown (KeyCode.N)) 
		{
			forceY = forceY + 5;
		}
		if (Input.GetKeyDown (KeyCode.M)) 
		{
			forceY = forceY - 10;
		} 
		
		GetComponent<Rigidbody>().AddForce (Vector3.up * forceY);
		//GetComponent<Rigidbody> ().AddForce (Vector3.right * 2);
		Transform playerTR = Rocket.transform;
		Vector3 position = playerTR.position;
		if (oldPositionY != position.y || oldPositionX != position.x || oldPositionZ != position.z)
			{
			PositionTextX.text = "Ball position X : " + position.x;
			PositionTextY.text = "Ball position Y : " + position.y;
			PositionTextZ.text = "Ball position Z : " + position.z;
			DisplayForceY.text = "Force Y : " + forceY;
			//sw.WriteLine (DateTime.Now + ";" + position.x + ";" + position.y + ";" + position.z + ";" + forceY,true);
		}
		oldPositionY = position.y;
		oldPositionX = position.x;
		oldPositionZ = position.z;
		//sw.Close ();
	}
}

