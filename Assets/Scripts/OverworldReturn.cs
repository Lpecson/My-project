using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverworldReturn : MonoBehaviour
{
    private AudioSource returnSound;
    private bool levelCompleted = false;
    // Start is called before the first frame update
    void Start()
    {
        returnSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // print("Collision");
        if (collision.gameObject.name == "Player(cowboy)" && !levelCompleted)
        {
            print("here");
            returnSound.Play();
            Invoke("ReturnOverworld", 2f);//call completelevel after 2 seconds
            levelCompleted = true;
        }
    }

    private void ReturnOverworld()
    {
        SceneManager.LoadScene("Overworld");
    }
}
