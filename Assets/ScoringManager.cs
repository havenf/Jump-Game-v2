using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoringManager : MonoBehaviour
{
    public double playerOneScore;
    public double playerTwoScore;
    public TextMeshProUGUI tmpUIP1;
    public TextMeshProUGUI tmpUIP2;

    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 70f;
        playerTwoScore = 30f;

        tmpUIP1 = GameObject.FindGameObjectWithTag("p1UIScore").GetComponent<TextMeshProUGUI>();
        tmpUIP2 = GameObject.FindGameObjectWithTag("p2UIScore").GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        tmpUIP1.text = $"Player 1: {(int)playerOneScore}";
        tmpUIP2.text = $"Player 2: {(int)playerTwoScore}";

        StartCoroutine(RunScoreSystem());
    }

    private IEnumerator RunScoreSystem()
    {

        playerOneScore -= 0.001;
        playerTwoScore += 0.005;

        Debug.Log((int)playerOneScore + " | " + (int)playerTwoScore);
        yield return new WaitForSeconds(1);
    }
}
