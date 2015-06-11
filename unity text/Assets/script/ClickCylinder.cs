using UnityEngine;
using System.Collections;

public class ClickCylinder : MonoBehaviour {
		public GameObject cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnMouseDown()
		{
				//Debug.Log ("click cube");
				cube.SetActive (true);
		//Application.LoadLevel ("1");

		}
}
