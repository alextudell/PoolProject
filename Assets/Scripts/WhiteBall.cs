using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBall : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    private void Update()
    {
        CheckWhiteBallPosition();
    }

    private void CheckWhiteBallPosition()
    {
            if (transform.position.x < 115f || transform.position.x > 162f)
            {
                transform.position = new Vector3(150f, 13.5f, 154f);
            }

            if (transform.position.z < 140f || transform.position.z > 170f)
            {
                transform.position = new Vector3(150f, 13.5f, 154f);
            }

            if (transform.position.y < 11.5f)
            {
                transform.position = new Vector3(150f, 13.5f, 154f);
                rb.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
}
