using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    private TMP_Text tmp_text;
    private void Awake()
    {
        tmp_text = GetComponent<TMP_Text>();
    }
    private void OnEnable()
    {
        GameManager.DataManager.OnCurScoreChanged += ChangeScore;
    }
    private void OnDisable()
    {
        GameManager.DataManager.OnCurScoreChanged -= ChangeScore;
    }
    private void ChangeScore(int score)
    {
        tmp_text.text = score.ToString();
    }
}
