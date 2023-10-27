using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 1;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Untagged")
        Debug.Log("Numero de paredes batidas: " + hits++);
    }
}
