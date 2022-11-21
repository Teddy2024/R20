using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("傷害目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸欲置物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("被打與爆炸音效")]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;
    

        private void OnCollisionEnter2D(Collision2D collision) 
        {
            if(collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));
            }
            
        }
    }
}

