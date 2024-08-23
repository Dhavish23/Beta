using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMan : MonoBehaviour
{
    [SerializeField]
    private GameObject man;

    void Start()
    {
        
        Instantiate(man, transform.position, Quaternion.identity);
    }
}
