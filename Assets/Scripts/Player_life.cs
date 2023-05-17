using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_life : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] public GameInfo gameinfo;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] public int hptotal;
    [SerializeField] public int hpleft;
    SpriteRenderer sRend;
    Material mDefault;
    Material mRed;
    float timer;
    bool invincible = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sRend = GetComponent<SpriteRenderer>();
        mDefault = sRend.material;
        mRed = Resources.Load("mRed", typeof(Material)) as Material;
        hptotal = gameinfo.PlayerHPTotal;
        hpleft = gameinfo.PlayerHPRemaining;
        //PlayerStats psobj;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            invincible = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Debug.Log("Collision");
            takeDMG();
            StartCoroutine("Flash");
            invinciblePeriod();
            if(hpleft <= 0)
            {
                Die();
            }
        }
    }
    private void Die()
    {
        //deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("Death");
        SceneManager.LoadScene("GameOver");
    }
    public void takeDMG()
    {
        hpleft--;
        //Flash();
        gameinfo.TakeDamage();
    }
    private void Heal()
    {
        hpleft++;
        gameinfo.Heal(1);
    }
    private void invinciblePeriod()
    {
        timer = 1;
        if(timer > 0)
        {
            invincible = true;
        }
    }
    IEnumerator Flash()
    {
        for(int i=0; i<3; i++)
        {
            yield return new WaitForSeconds(0.15f);
            sRend.material = mRed;
            Invoke("ResetMaterial", 0.1f);
        }
    }
    private void ResetMaterial()
    {
        sRend.material = mDefault;//reset material to default
    }
}
