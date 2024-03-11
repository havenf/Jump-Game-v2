using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneControlPanelButton : MonoBehaviour
{
    GameObject extendableBridge;
    private bool isPlayerOne;
    private bool playerCloseEnough;

    void Start()
    {
        extendableBridge = GameObject.Find("ExtendableBridge");
        isPlayerOne = GameObject.Find("p1Panel").GetComponent<ControlPanel>().isPlayerOne;
        playerCloseEnough = GameObject.Find("p1Panel").GetComponent<ControlPanel>().playerCloseEnough;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerOne == true && playerCloseEnough == true && Input.GetKey(KeyCode.E))
        {

            Debug.Log("Panel Enabled");
            extendableBridge.transform.localScale += new Vector3(0.4087168f, 0.01308092f, 0.6881f);
        }
    }
}
