using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField, Header("傷害目標")]
    private string nameTarget;
    [SerializeField, Header("爆炸欲置物")]
    private GameObject prefabExplosion;
  

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.name.Contains(nameTarget))
        {
            Instantiate(prefabExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
}
