using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    public float speed = 14f;
    public PlayerController script;
    public bool right;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
