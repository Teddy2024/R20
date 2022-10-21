using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Teddy
{
 public class Learn : MonoBehaviour
  {
    ///<summary>
    /// 簡單應用
    ///</summary>
    [Header("整數")]
    public int lv = 1;
    public int enemies = 10;
    //private int darkenemies = 5;
    [Header("浮點數")]
    public float speed = 0.9f;
    [Header("字串")]
    public string playerName = "打飛機";
    [Header("布林值")]
    [Tooltip("An orgasm is what usually happens when you reach the height of sexual arousal.")]
    public bool isCuming = false;
    public bool isComing = true;
    
    [Range(0,100)]
    public int hp = 1;
    [Range(0f,100f)]
    public float power = 10.1f;
    [SerializeField]
    private float superPower = 10000f;

  }
}
