using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    [SerializeField] public State curState;
    public enum State { Ready, Play, GameOver }
    public UnityEvent OnReadyed;
    public UnityEvent OnPlayed;
    public UnityEvent OnGameOvered;

    private void Start()
    {
        Ready();
        GameManager.DataManager.CurScore = 0;
    }
    public void Ready()
    {
        curState = State.Ready;
        OnReadyed?.Invoke();
    }

    public void Play()
    {
        curState = State.Play;
        OnPlayed?.Invoke();
    }
    public void GameOver()
    {
        curState = State.GameOver;
        OnGameOvered?.Invoke();
    }
    
}
