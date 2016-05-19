using UnityEngine;
using System.Collections;

public class ServerSocket : MonoBehaviour {
    ListenerSocket listener = new ListenerSocket();
	// Use this for initialization
	void Start () {
        listener.Listen(55555);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
