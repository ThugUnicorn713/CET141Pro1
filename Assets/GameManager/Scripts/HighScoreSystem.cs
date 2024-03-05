using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreSystem : MonoBehaviour
{
    List<PlayerScore> highScoreList = new List<PlayerScore>();

    [SerializeField] List<TextMeshProUGUI> highPlayersTMP = new List<TextMeshProUGUI>();
    [SerializeField] List<TextMeshProUGUI> highScoresTMP = new List<TextMeshProUGUI>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
