using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : FireSystemBase
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
          SpawnBullet();
        }
    }
}
