using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomDoorT1 : MonoBehaviour
{
     List<int> rooms = new List<int>{ 3, 4, 5, 6 };
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getNext()
    {
        int size = rooms.Count - 1;
        int ret = rooms[Random.Range(0, size)];
        rooms.Remove(ret);
        return ret;
    }
}
