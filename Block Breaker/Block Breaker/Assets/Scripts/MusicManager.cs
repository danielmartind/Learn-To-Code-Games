using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	public static MusicManager Instance = null;

	private void Awake()
	{        
		if (Instance != null)
		{
			Destroy(gameObject);
			print("Destroyed!");
		}
		else
		{
			Instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
