using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    public class EnemyFire : FireSystemBase
    {
        [SerializeField, Header("生成間隔"), Range(0,10)]
        private float interval = 1.5f;

        private void Awake() 
        {
            
        }
        private void OnBecameVisible() 
        {
            //(方法 延遲時間 間隔)
            InvokeRepeating("SpawnBullet", 0, interval);
        }
        private void OnBecameInvisible() 
        {
            Destroy(gameObject);
        }
        
    }
}

