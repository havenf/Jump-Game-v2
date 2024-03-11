using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    float distance;
    GameObject player1;
    GameObject player2;
    public bool playerCloseEnough;
    public bool isPlayerOne;

    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("p1rb");
        player2 = GameObject.FindGameObjectWithTag("p2rb");
        distance = 0.13f;

    }
    void Update()
    {
        if (Vector3.Distance(this.transform.position, player1.transform.position) < distance)
        {
            playerCloseEnough = true;
            isPlayerOne = true;
        }
        else if (Vector3.Distance(this.transform.position, player2.transform.position) < distance)
        {
            playerCloseEnough = true;
            isPlayerOne = false;
        }
        else
        {
            playerCloseEnough = false;
        }
        Debug.Log(playerCloseEnough + " | " + isPlayerOne + " | " + Vector3.Distance(this.transform.position, player1.transform.position));
    }
}
