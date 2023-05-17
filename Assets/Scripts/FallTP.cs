using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallTP : MonoBehaviour
{
    public Player_life lifescript;
    private AudioSource fallSound;
    // Start is called before the first frame update
    void Start()
    {
        fallSound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Collision");
        if (collision.gameObject.name == "Player(cowboy)")
        {
            Invoke("ResetLevelAndDmg", 0f);
        }
    }
    private void ResetLevelAndDmg()
    {
        lifescript.takeDMG();
        fallSound.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        /*if (lifescript.isDEAD)
        {
            //loadGameOverScreen
        }
        else
        {
           
        }*/
    }
}
