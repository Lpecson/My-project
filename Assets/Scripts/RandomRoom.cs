using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomRoom : MonoBehaviour
{   //3 4 5 6
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "TP")
        {
            print("Tier 1 teleporter");
            print(gameObject.name);
            if (collision.gameObject.name == "Player(cowboy)")
            {
                int room = Random.Range(4, 8);//change range when finished building maps
                Debug.Log(room);
                ChangeLevel(room);
            }
        }
        else if(gameObject.tag == "TP2")
        {
            print("Tier 2 teleporter");
            print(gameObject.name);
            if (collision.gameObject.name == "Player(cowboy)")
            {
                int room = Random.Range(10, 12);
                Debug.Log(room);
                ChangeLevel(room);
            }
        }
    }
    private void ChangeLevel(int x)
    {
        // print("in func CompleteLevel");
        SceneManager.LoadScene(x);
    }
}
