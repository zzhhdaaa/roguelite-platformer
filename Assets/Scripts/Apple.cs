using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Apple : MonoBehaviour
{
    public UnityEvent OnPick;
    private void OnTriggerEnter2D(Collider2D col)
    {
        OnPick?.Invoke();
        Destroy(gameObject);
    }
}
