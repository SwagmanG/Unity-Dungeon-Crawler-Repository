using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class GameManager : MonoBehaviour
{
    private Map gameMap;

    public void Start()
    {
        Debug.Log("GameManager Start");

        gameMap = new Map();

        Debug.Log("GameManager Map Created");
    }
}