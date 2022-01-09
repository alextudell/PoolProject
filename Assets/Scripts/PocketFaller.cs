using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketFaller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.constraints = RigidbodyConstraints.None;
    }
}
