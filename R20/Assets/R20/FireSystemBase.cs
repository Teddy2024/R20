using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSystemBase : MonoBehaviour
{
   [SerializeField, Header("子彈欲置物")]
   private GameObject prefabBullet;
   [SerializeField, Header("子彈生成點")]
   private Transform pointSpawn;

   protected void SpawnBullet()
   {
    Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
   }
}
