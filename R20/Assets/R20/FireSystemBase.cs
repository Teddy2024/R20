using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
   public class FireSystemBase : MonoBehaviour
   {
      [SerializeField, Header("子彈欲置物")]
      private GameObject prefabBullet;
      [SerializeField, Header("子彈生成點")]
      private Transform pointSpawn;
      [SerializeField, Header("發射音效")]
      private AudioClip soundFire;

      protected void SpawnBullet()
      {
         Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
         SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
      }
   }
}
