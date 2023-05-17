using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnerScript : MonoBehaviour
{
    public GameInfo gameinfo;
    public GameObject Cherry;
    public GameObject DoubleJump;
    public GameObject PowerRing;
    public GameObject RangeUp;
    public GameObject JumpHeightUp;
    public GameObject SpeedPotion;
    public GameObject Strawberry;
    public GameObject Melon;
    public GameObject Thorns;
    public GameObject Bomb;
    public GameObject healthPotion;
    public GameObject winGame;
    public GameObject speeddouble;
    public GameObject speedhalf;
    public GameObject jumpdouble;
    public GameObject jumphalf;
    public GameObject Chicken;
    public GameObject sacJump;
    public GameObject sacSpeed;
    public GameObject RiskIt;
    public GameObject doubleshot;

    // Start is called before the first frame update
    void Start()
    {
        if(gameinfo.rewardNum == 4)
        {
            Instantiate(DoubleJump, transform.position, Quaternion.identity);
        }
        if(gameinfo.rewardNum == 8)
        {
            Instantiate(winGame, transform.position, Quaternion.identity);
        }
        else
        {
            int item = Random.Range(1, 20);
            switch (item)
            {
                case 1:
                    Instantiate(Cherry, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(DoubleJump, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(PowerRing, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(RangeUp, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(JumpHeightUp, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(SpeedPotion, transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(Strawberry, transform.position, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(Melon, transform.position, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(Thorns, transform.position, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(Bomb, transform.position, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(healthPotion, transform.position, Quaternion.identity);
                    break;
                case 12:
                    Instantiate(speeddouble, transform.position, Quaternion.identity);
                    break;
                case 13:
                    Instantiate(speedhalf, transform.position, Quaternion.identity);
                    break;
                case 14:
                    Instantiate(jumpdouble, transform.position, Quaternion.identity);
                    break;
                case 15:
                    Instantiate(jumphalf, transform.position, Quaternion.identity);
                    break;
                case 16:
                    Instantiate(Chicken, transform.position, Quaternion.identity);
                    break;
                case 17:
                    Instantiate(sacJump, transform.position, Quaternion.identity);
                    break;
                case 18:
                    Instantiate(sacSpeed, transform.position, Quaternion.identity);
                    break;
                case 19:
                    Instantiate(RiskIt, transform.position, Quaternion.identity);
                    break;
                case 20:
                    Instantiate(doubleshot, transform.position, Quaternion.identity);
                    break;
                default:
                    break;
            }
        }
    }
}
