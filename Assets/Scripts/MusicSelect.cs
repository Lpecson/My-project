using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelect : MonoBehaviour
{
    [SerializeField] private AudioSource PirateSong;
    [SerializeField] private AudioSource CowboySong;
    public GameInfo gameinfo;
    // Start is called before the first frame update
    void Start()
    {
        if(gameinfo.isCowboy)
        {
            CowboySong.Play();
        }
        else
        {
            PirateSong.Play();
        }
    }
}
