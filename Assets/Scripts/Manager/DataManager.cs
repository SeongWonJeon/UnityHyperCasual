using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    // ���� ���ھ�� ����Ʈ ���ھ ����
    // ���� ����� ����Ʈ���ھ �̺�Ʈ�� ȣ���Ų��
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

    // ���� ������� ���ھ ���ؼ� �̺�Ʈ�� ȣ���Ų��
    private int curScore;
    public int CurScore
    {
        get { return curScore; }
        set
        {
            OnCurScoreChanged?.Invoke(value);
            curScore = value;

            if (curScore > BestScore)   // ���� ���ھ ����Ʈ���ھ�� ���ٸ� 
                BestScore = curScore;   // ���罺�ھ ����Ʈ���ھ�� ��ȯ
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}
