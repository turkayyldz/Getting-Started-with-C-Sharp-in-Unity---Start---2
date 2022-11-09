using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractionScreenParameters : MonoBehaviour
{
    public AttractionConfigs _AttractionConfigs;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
