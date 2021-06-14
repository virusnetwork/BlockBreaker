using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float screenWidthInUnits =16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = new Vector2(Mathf.Clamp(Input.mousePosition.x / Screen.width * screenWidthInUnits,0f,16f),transform.position.y);
    }
}
