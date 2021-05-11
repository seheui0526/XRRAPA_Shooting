using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public GameObject player;
    public AudioSource bgm;

    public static SoundManager sm;

    // Singletone pattern
    void Awake()
    {
        if(sm == null)
        {
            sm = this;
        }
        else
        {
            Destroy(this);
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayGameoverSound()
    {
        bgm.Stop();
        GetComponent<AudioSource>().Play();
    }

}
