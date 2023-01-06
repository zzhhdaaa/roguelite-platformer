using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelPass : MonoBehaviour
{
    public Text levelPassText;

    private void OnTriggerEnter2D(Collider2D col)
    {
        var currentScene = SceneManager.GetActiveScene();

        levelPassText.gameObject.SetActive(true);

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
