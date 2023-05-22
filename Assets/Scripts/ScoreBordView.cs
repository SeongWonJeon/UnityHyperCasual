using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBordView : MonoBehaviour
{
    [SerializeField] private TMP_Text curText;
    [SerializeField] private TMP_Text bestText;


    private void OnEnable()
    {
        curText.text = GameManager.DataManager.CurScore.ToString();
        bestText.text = GameManager.DataManager.BestScore.ToString();
    }
}
