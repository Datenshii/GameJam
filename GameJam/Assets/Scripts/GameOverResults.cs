using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverResults : MonoBehaviour {

    public Text message;
	
	void Update () {
        message.text = ("This area is now purged \n Score: " + PlayerData.Score);		
	}
}
