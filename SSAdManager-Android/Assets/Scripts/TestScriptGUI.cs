using UnityEngine;
using System.Collections;

public class TestScriptGUI : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(0, 0, 300, 100), "Show Chartboost Full screen Ad"))
		{
			SSAdManager.showChartBoostFullScreenAd();
		}
		
		if(GUI.Button(new Rect(0, 150, 300, 100), "Show Chartboost More Games Ad"))
		{
			SSAdManager.showChartBoostMoreGamesAd();
		}
	}
}