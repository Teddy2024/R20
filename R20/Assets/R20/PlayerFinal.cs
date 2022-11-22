using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    public class PlayerFinal : MonoBehaviour
    {
      private void OnDestroy() 
      {
        FinalManager.instance.GameOver("老媽看到發射失敗");
      }
      private void OnTriggerEnter2D(Collider2D other) 
      {
        FinalManager.instance.GameOver("射完還要打飛機");
      }
    }  
}

