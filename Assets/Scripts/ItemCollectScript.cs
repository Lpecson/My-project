using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectScript : MonoBehaviour
{
    public PlayerController script;
    //private int cherries = 0;
    [SerializeField] private AudioSource collectSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.CompareTag("Collectable Item") )
        {
            if(collision.gameObject.name == "Cherry" || collision.gameObject.name == "Cherry(Clone)" )
            {
                script.getCherry();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "DoubleJump" || collision.gameObject.name == "DoubleJump(Clone)")
            {
                script.getDouble();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "PowerRing" || collision.gameObject.name == "PowerRing(Clone)" )
            {
                script.DMGUP();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "RefreshJump" || collision.gameObject.name == "RefreshJump(Clone)")
            {
                script.refreshJump();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "SpeedPotion" || collision.gameObject.name == "SpeedPotion(Clone)" )
            {
                script.speedUp();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "SpeedDown" || collision.gameObject.name == "SpeedDown(Clone)")
            {
                script.speedDown();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "JumpHeightUp" || collision.gameObject.name == "JumpHeightUp(Clone)")
            {
                script.JumpHeightUp();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "RangeUp" || collision.gameObject.name == "RangeUp(Clone)")
            {
                script.RangeUp();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "Melon" || collision.gameObject.name == "Melon(Clone)" )
            {
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }            
            if(collision.gameObject.name == "Strawberry" || collision.gameObject.name == "Strawberry(Clone)" )
            {
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "Thorns" || collision.gameObject.name == "Thorns(Clone)" )
            {
                script.getThorns();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "Bomb" || collision.gameObject.name == "Bomb(Clone)" )
            {
                Destroy(collision.gameObject);
                script.getBomb();
            }
            if(collision.gameObject.name == "HealthPotion" || collision.gameObject.name == "HealthPotion(Clone)")
            {
                script.getHealthPotion();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "WinGame" || collision.gameObject.name == "WinGame(Clone)")
            {
                script.WinGame();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "SpeedHalf" || collision.gameObject.name == "SpeedHalf(Clone)")
            {
                script.halfspeed();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "SpeedDouble" || collision.gameObject.name == "SpeedDouble(Clone)")
            {
                script.doublespeed();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "JumpHeight_2" || collision.gameObject.name == "JumpHeight_2(Clone)")
            {
                script.halfjumpheight();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "JumpHeightx2" || collision.gameObject.name == "JumpHeightx2(Clone)")
            {
                script.doublejumpheight();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "Chicken" || collision.gameObject.name == "Chicken(Clone)")
            {
                script.getChicken();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "LoseGame" || collision.gameObject.name == "LoseGame(Clone)")
            {
                script.LoseGame();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "SacSpeed" || collision.gameObject.name == "SacSpeed(Clone)")
            {
                script.sacSpeed();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "SacJump" || collision.gameObject.name == "SacJump(Clone)")
            {
                script.sacJump();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "RiskIt" || collision.gameObject.name == "RiskIt(Clone)")
            {
                script.riskIt();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
            if(collision.gameObject.name == "DoubleShot" || collision.gameObject.name == "DoubleShot(Clone)")
            {
                script.getDoubleShot();
                collectSoundEffect.Play();
                Destroy(collision.gameObject);
            }
        }
    }
    
}
