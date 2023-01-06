using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelPass : MonoBehaviour
{
    public UnityEvent OnPass;

    private void OnTriggerEnter2D(Collider2D col)
    {
        var currentScene = SceneManager.GetActiveScene();

        OnPass?.Invoke();

        StartCoroutine(Delay(2.0f, () =>
        {
            SceneManager.LoadScene(currentScene.name);
        }));
    }

    IEnumerator Delay(float seconds, Action onFinish)
    {
        yield return new WaitForSeconds(seconds);
        onFinish();
    }
}
