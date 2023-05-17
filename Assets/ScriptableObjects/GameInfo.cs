using UnityEngine;
[CreateAssetMenu(fileName = "Gameinfo", menuName = "PersistentGameinfo")]
public class GameInfo : ScriptableObject
{   //default vals
    public int PlayerHPTotal = 3;
    public int PlayerHPRemaining = 3;
    public int PlayerHasDouble = 0;
    public int PlayerDMG = 1;
    public float PlayerMS = 7f;
    public float PlayerJumpHeight = 14f;
    public int PlayerAmmoTotal = 2;
    public int PlayerAmmoRemain = 2;
    public float PlayerReloadTime = 1.5f;
    public int PlayerRange = 1;
    public float ProjectileBaseSpeed;
    public bool isCowboy;
    public bool hasThorns;
    public int currentLevel;
    public int rewardNum;
    public bool doubleShot;
    //reset all stats to default vals
    public void InitGame()
    {
        PlayerHPTotal = 3;
        PlayerHPRemaining = 3;
        PlayerHasDouble = 0;
        PlayerMS = 7f;
        PlayerJumpHeight = 14f;
        PlayerAmmoTotal = 2;
        PlayerAmmoRemain = 2;
        PlayerReloadTime = 1.5f;
        ProjectileBaseSpeed = PlayerMS * 2;
        isCowboy = false;
        rewardNum = 0;
        doubleShot = false;
    }
    public void getDS()
    {
        doubleShot = true;
    }
    public void havthorns()
    {
        hasThorns = true;
    }
    public void PlayCowboy()
    {
        PlayerMS = PlayerMS+0.5f;
        isCowboy = true;
    }
    public void PlayPirate()
    {
        PlayerMS = PlayerJumpHeight+1f;
        isCowboy = false;
    }
    public float getProjSpeed()
    {
        ProjectileBaseSpeed = PlayerMS * 2;
        return ProjectileBaseSpeed;
    }
    public int TakeDamage()
    {
        PlayerHPRemaining--;
        return PlayerHPRemaining;
    }
    public void ResetHealth()
    {
        PlayerHPRemaining = PlayerHPTotal;
    }    
    public int HPUP()
    {
        PlayerHPRemaining++;
        PlayerHPTotal++;
        return PlayerHPRemaining;
    }
    public int Heal(int x)
    {
        if(PlayerHPRemaining < PlayerHPTotal)
        {
            PlayerHPRemaining += x;
            if(PlayerHPRemaining > PlayerHPTotal)
            {
                PlayerHPRemaining = PlayerHPTotal;
            }
        }
        return PlayerHPRemaining;
    }

    public void fullHeal()
    {
        PlayerHPRemaining = PlayerHPTotal;
    }

    public void GetDouble()
    {
        PlayerHasDouble = 1;
    }
    public void chooseCharacter(int x)
    {
        if(x == 1)
        {
            isCowboy = true;
        }
        else
        {
            isCowboy = false;
        }
    }
}
