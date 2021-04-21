
/*

CODY

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour 
{
    // configuration parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float xMin = 1f;
    [SerializeField] float xMax = 15f;

    void Start()
    {

    }

    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, xMin, xMax);
        transform.position = paddlePos;
    }
}