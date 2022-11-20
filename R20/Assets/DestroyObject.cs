using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0,3)]
        private float destroyTime = 0.5f;
       
        private void Awake() 
        {
            Destroy(gameObject, destroyTime);
        
        }
        //可見事件 當Renderer出現在Scene或Game時執行一次
        private void OnBecameVisible()
        {
            
        }
        //不可見事件 當Renderer離開在Scene或Game時執行一次
        private void OnBecameInvisible() 
        {
            Destroy(gameObject);
        }
       
    }
    
}
