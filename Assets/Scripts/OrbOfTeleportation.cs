using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbOfTeleportation : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = new Vector3(Random.Range(120f, 158), 13.48f, Random.Range(147f, 161.4f));
        }
        else
        {
            other.transform.localPosition = new Vector3(Random.Range(-7f, 30f), 5.256f, Random.Range(-7f, 6f));
        }
    }
}
