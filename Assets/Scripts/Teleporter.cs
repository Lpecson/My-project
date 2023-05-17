using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    private AudioSource doorSound;
    [SerializeField] private Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        doorSound = GetComponent<AudioSource>();
    }
    public Transform GetDestination()
    {
        return destination;
    }

    private void ChangeLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
