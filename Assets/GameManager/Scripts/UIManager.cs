using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreValue;
    [SerializeField] TextMeshProUGUI timeValue;
    [SerializeField] GameObject gameoverPanel;
    [SerializeField] TextMeshProUGUI endScoreValue;
    void Start()
    {
        UpdateScoreUI(0);
        UpdateTimeUI(0);
        
    }

    // Update is called once per frame
     public void UpdateScoreUI(int value)
     {
        // "D5" - min of 5 digits, preceding shorter numbers with 0s

        scoreValue.text = value.ToString("D5");

     }

    public void UpdateTimeUI(float time)
    {
        int seconds = (int)time;
        timeValue.text = System.TimeSpan.FromSeconds(seconds).ToString("hh':'mm':'ss");
    }

    public void ActivateEndGame(int score)
    {
        endScoreValue.text = score.ToString();
        gameoverPanel.SetActive(true);
        Cursor.visible = true;
    } 
}
