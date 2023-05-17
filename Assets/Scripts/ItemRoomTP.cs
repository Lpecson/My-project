using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemRoomTP : MonoBehaviour
{
    public GameInfo gameinfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "TP")
        {
            print("Tier 1 teleporter");
            print(gameObject.name);
            if (collision.gameObject.name == "Player(cowboy)")
            {
                gameinfo.rewardNum++;
                SceneManager.LoadScene("Level 1-Reward");
            }
        }
        else if (gameObject.tag == "TP2")
        {
            print("Tier 2 teleporter");
            print(gameObject.name);
            if (collision.gameObject.name == "Player(cowboy)")
            {
                gameinfo.rewardNum++;
                SceneManager.LoadScene("Level 2-Reward");
            }
        }
    }
}
