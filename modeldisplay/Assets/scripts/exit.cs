using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class exit : MonoBehaviour {
    public void doquit(){
        Debug.Log("Player quit the game");
        Application.Quit();
    }
}
