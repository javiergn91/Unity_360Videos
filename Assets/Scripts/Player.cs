using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player instance;

    public static Player Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Player>();
            }

            return instance;
        }
    }

    public void MoveTo(Transform end)
    {
        Debug.Log("MoveTo");
        transform.position = end.position;
    }
}
