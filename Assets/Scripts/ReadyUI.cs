using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReadyUI : MonoBehaviour
{
    [SerializeField] private GameSceneFlow flow;
    private void OnPlay()
    {
        flow.Play();
    }
}
