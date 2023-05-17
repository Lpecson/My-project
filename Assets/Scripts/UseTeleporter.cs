using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseTeleporter : MonoBehaviour
{
    private GameObject currentTP;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Vertical"))
        {
            if (currentTP != null)
            {
                transform.position = currentTP.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleport"))
        {
            currentTP = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleport"))
        {
            currentTP = null;
        }
    }
}
