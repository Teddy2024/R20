using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    public class MoveSystem : MonoBehaviour
    {

        [SerializeField, Header("移動速度"), Range(-10,0)]
        private float speed = -3.5f;

        // Update is called once per frame
        void Update()
        {
            transform.Translate(speed* Time.deltaTime, 0, 0);
        }
    }
}

