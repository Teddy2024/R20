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
    [SerializeField, Header("圖片元件")]
    private SpriteRenderer spr;



    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(speedHorizontal * Time.deltaTime * h, 
                            speedVertical * Time.deltaTime * v,
                            0);

        if(v > 0)
        {
            print("up");
            spr.sprite = planeUP;

        }
        if(v < 0)
        {
            print("down");
            spr.sprite = planeDown;
        }
        if(v == 0)
        {
            print("middle");
            spr.sprite = planeMiddle;
        }
        
    }
}
