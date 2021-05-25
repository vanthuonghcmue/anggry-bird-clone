using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelController : MonoBehaviour
{
    [SerializeField] string _nextLevel;
    private zombie[] _zombies;

    void OnEnable()
    {
        _zombies = FindObjectsOfType<zombie>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ZombeAreAllDead())
             GotoNextLevel();
    }

    private void GotoNextLevel()
    {
        Debug.Log("Goto level" + _nextLevel);
        SceneManager.LoadScene(_nextLevel);
    }

    private bool ZombeAreAllDead()
    {
        foreach(var zombie in _zombies)
        {
            if (zombie.gameObject.activeSelf)
                return false;
        }
        return true;
    }
}
