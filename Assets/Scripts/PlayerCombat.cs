using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] public GameInfo gameInfo;
    public float movespeed;
    //public bool fireUp;
    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Ranged"))
        {
            Debug.Log("Ranged attack");
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }
}
