using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Combat : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    [SerializeField] private Transform hands;
    [SerializeField] private Transform headWrapper;
    [SerializeField] private Transform character;

    private Vector3 handPosition;
    private Animator handAnim;
    private bool isAttacking;
    private float verticalInput;
    private bool attackInputDown;


    // Start is called before the first frame update
    private void Start()
    {
        damage = 1;
        handAnim = hands.GetComponent<Animator>();
        handPosition = hands.localPosition;
    }
    // Update is called once per frame
    void Update()
    {
        getInput();
        AdjustHandsPosAndRotation();
        handleAttack();
    }
    private void getInput()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
        attackInputDown = Input.GetButtonDown("Melee");
    }
    private void AdjustHandsPosAndRotation()
    {
        hands.eulerAngles = new Vector3(0, 0, 90 * verticalInput * character.localScale.x);//rotation
        hands.localPosition = handPosition + new Vector3(0, verticalInput, 0);
    }
    private void handleAttack()
    {
        var clipsInfo = handAnim.GetCurrentAnimatorClipInfo(0);
        if(clipsInfo.Length == 0 && isAttacking)
        {
            isAttacking = false;
            hands.gameObject.SetActive(false);
        }
        if(attackInputDown && !isAttacking)
        {
            hands.gameObject.SetActive(true);
            handAnim.SetTrigger("MeleeAttack");
            isAttacking = true;
        }
    }
}