using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private ScoringManager _sm;
    private TextMeshProUGUI winningBanner;

    private int winAmount = 500;

    // Start is called before the first frame update
    void Start()
    {
        _sm = GameObject.FindGameObjectWithTag("scoring").GetComponent<ScoringManager>();
        winningBanner = GameObject.FindGameObjectWithTag("WinBanner").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        if (_sm.playerOneScore < winAmount && _sm.playerTwoScore < winAmount)
        {
            winningBanner.text = "";
        }

        else if (_sm.playerOneScore > winAmount && _sm.playerTwoScore < winAmount)
        {
            winningBanner.text = "Player One Wins!";
        }

        else if (_sm.playerOneScore < winAmount && _sm.playerTwoScore > winAmount)
        {
            winningBanner.text = "Player Two Wins!";
        }

        else
        {
            winningBanner.text = "";
        }

    }

    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
    }
}
