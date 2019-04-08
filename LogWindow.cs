﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
public class LogWindow : MonoBehaviour {
	// Use this for initialization
	StringBuilder sb = new StringBuilder();
	public GameObject logWin;
	public Text log;
	void Awake() {
		sb.Length = 0;
		Application.logMessageReceived += LogCallback;
		Debug.Log ("sadsd");
		Debug.Log ("sadsd");
		Debug.Log ("sadsd");
		GameObject a = null;
		Debug.Log (a.transform);
	}
	public void LogCallback (string condition, string stackTrace, LogType type)
	{
		if (type == LogType.Log) {
			sb.Append (condition + stackTrace + "\n");
		} else {
			sb.Append ("<color=red>"+condition + stackTrace+"</color>" + "\n");
		}
		log.text = sb.ToString ();
	}
	public void OnClick()
	{
		logWin.SetActive (!logWin.activeSelf);
	}
}
