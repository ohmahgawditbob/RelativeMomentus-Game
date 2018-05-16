using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelativisticLight : MonoBehaviour {
	public Vector3 viw;
	//Keep track of Game State so that we can reference it quickly
	public GameState state;
	public bool Star;

	private Light light;
	private Transform transform;

	// Use this for initialization
	void Start () {
		light = gameObject.AddComponent<Light>();
		transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
