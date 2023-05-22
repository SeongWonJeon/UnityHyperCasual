using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    // 현재 스코어와 베스트 스코어를 넣자
    // 현재 기록한 베스트스코어를 이벤트로 호출시킨다
    private int bestScore;
    public int BestScore 
    {
        get { return bestScore; }
        set
        {
            if (bestScore != value)
                OnBestScoreChanged?.Invoke(value);
            bestScore = value;
        }
    }
    public event UnityAction<int> OnBestScoreChanged;

    // 현재 기록중인 스코어에 대해서 이벤트로 호출시킨다
    private int curScore;
    public int CurScore
    {
        get { return curScore; }
        set
        {
            OnCurScoreChanged?.Invoke(value);
            curScore = value;

            if (curScore > BestScore)   // 현재 스코어가 베스트스코어보다 높다면 
                BestScore = curScore;   // 현재스코어를 베스트스코어로 변환
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}
