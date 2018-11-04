using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLocation : MonoBehaviour
{
    public Image filled;
    public Transform newLocation;

    private float timeToLoad = 1;
    private bool isLoading = false;
    private float currTime = 0;

    public void StartLoading()
    {
        Debug.Log("StartLoading");
        isLoading = true;
        currTime = 0;
    }

    public void StopLoading()
    {
        Debug.Log("StopLoading");
        isLoading = false;
        filled.fillAmount = 0;
    }

    private void FixedUpdate()
    {
        if(isLoading)
        {
            currTime += Time.deltaTime;

            float t = currTime / timeToLoad;

            filled.fillAmount = t;

            if(t >= 1)
            {
                Player.Instance.MoveTo(newLocation);
                isLoading = false;
            }
        }
    }
}
