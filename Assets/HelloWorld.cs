using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string _awakeMassenge = "SiliconMade";

    

    public Vector2  vector2;
    public Vector3 vector3;
    public double _double;
    public bool _bool;
    public float _fload;
    public char _char;


    private void Awake()
    {
        Debug.Log(vector2);
        Debug.Log(vector3);
        Debug.Log(_double);
        Debug.Log(_bool);
        Debug.Log(_fload);
       
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
