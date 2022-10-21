using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [Header("速度")]
    [SerializeField, Range(0, 10)]
    public float speedVertical = 3.5f;
    [SerializeField, Range(0, 10)]
    public float speedHorizontal = 4f;
    [Header("圖片")]
    public Sprite planeUP;
    public Sprite planeDown;
    public Sprite planeMiddle;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
