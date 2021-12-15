using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Shapes;

public class Aim : MonoBehaviour
{
    Line line;
    public Vector2 MousePosition
    {
        get { return Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()); }
    }

    public Vector2 NormalizedAimLine
    {
        get { return (MousePosition - (Vector2)transform.position).normalized; }
    }
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponentInChildren<Line>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //line.End = NormalizedAimLine;   
        line.transform.right = NormalizedAimLine;
    }
}
