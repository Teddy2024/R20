using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KID
{
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        private AudioSource aud;
        // Start is called before the first frame update
        void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

       public void PlaySound(AudioClip sound, Vector2 rangeVolume)
       {
        float volume = Random.Range(rangeVolume.x, rangeVolume.y);
        aud.PlayOneShot(sound, volume);
       }
    }
}

