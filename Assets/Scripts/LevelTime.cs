using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : MonoBehaviour
{
    private Text mText;
    
    // Start is called before the first frame update
    void Start()
    {
        mText = GetComponent<Text>();
    }

    private float mCurrentSeconds = 0f;
    
    // Update is called once per frame
    void Update()
    {
        mCurrentSeconds += Time.deltaTime;

        if (Time.frameCount % 20 == 0)
        {
            mText.text = ((int)mCurrentSeconds).ToString();
        }
    }
}
