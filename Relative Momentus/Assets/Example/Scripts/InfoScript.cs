using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
///Written by user tyoc213
public class InfoScript : MonoBehaviour {
	GameObject infoPanel;
	GameObject speedPanel;
	public GameObject canvas;
	//Gamestate reference for quick access
	private List<GameObject> speedPanelChildren = new List<GameObject>();
	GameState state;
	// Use this for initialization
	void Start () {
		if (canvas != null) {
			GameObject go = Resources.Load<GameObject>("GameObjects/InfoPanel");
			GameObject go2 = Resources.Load<GameObject> ("GameObjects/SpeedPanel");
			if(go != null){
				infoPanel = Instantiate(go);
				infoPanel.GetComponent<Transform>().SetParent(canvas.GetComponent<Transform>(), false);
			}
			if (go2 != null) {
				speedPanel = Instantiate (go2);
				speedPanel.GetComponent<Transform>().SetParent(canvas.GetComponent<Transform>(), false);
				Transform[] transform = speedPanel.GetComponentsInChildren<Transform>();

				foreach (Transform child in transform)
				{
					if (child != transform[0]){
						speedPanelChildren.Add(child.gameObject);
					}
				}
			}

		}
		state = GetComponent<GameState>();
	}

	//just print out a bunch of information onto the screen.
	void Update(){
		double pctOfLightSpeed = (state.PlayerVelocity / state.SpeedOfLight) * 100;
		string msg = "Current % of C: " + pctOfLightSpeed.ToString("n1")
			+ "\n\nCurrent Speed: " + state.PlayerVelocity.ToString("n2");
		UnityEngine.UI.Text text = infoPanel.GetComponentInChildren<UnityEngine.UI.Text> ();
		text.text = msg;
		if (pctOfLightSpeed > 99) {
			speedPanelChildren [0].SetActive (true);
			speedPanelChildren [2].SetActive (true);
			speedPanelChildren [4].SetActive (true);
		} else if (pctOfLightSpeed > 75) {
			speedPanelChildren [0].SetActive (true);
			speedPanelChildren [2].SetActive (true);
			speedPanelChildren [4].SetActive (false);
		} else if (pctOfLightSpeed > 50) {
			speedPanelChildren [0].SetActive (true);
			speedPanelChildren [2].SetActive (false);
			speedPanelChildren [4].SetActive (false);
		} else {
			speedPanelChildren [0].SetActive (false);
			speedPanelChildren [2].SetActive (false);
			speedPanelChildren [4].SetActive (false);
		}
	}

}
