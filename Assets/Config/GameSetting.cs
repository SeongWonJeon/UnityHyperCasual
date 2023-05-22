using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    private static void Init()
    {
        InitGameManager();
    }

    private static void InitGameManager()
    {
        if (GameManager.Incetance == null)
        {
            GameObject gameManager = new GameObject() { name = GameManager.DefaultName };
            gameManager.AddComponent<GameManager>();
        }
    }
}
