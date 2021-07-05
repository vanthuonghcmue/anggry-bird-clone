using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    public static levelController instance { get; private set; }
    public int nextLevel;
    private zombie[] _zombies;

    void Awake()
    {
        instance = this;
    }
    void OnEnable()
    {
        _zombies = FindObjectsOfType<zombie>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ZombeAreAllDead())
        {
            GameOverWin();
        }

        if( Bird.Instance.numberOfBirds == 0)
        {
            GameOverLose();
        }
    }

    private void GameOverWin()
    {
        SceneManager.LoadScene("game over");
    }
    public void GameOverLose()
    {
         SceneManager.LoadScene("lose");
    }

    private bool ZombeAreAllDead()
    {
        foreach (var zombie in _zombies)
        {
            if (zombie.gameObject.activeSelf)
                return false;
        }
        return true;
    }
}
  
