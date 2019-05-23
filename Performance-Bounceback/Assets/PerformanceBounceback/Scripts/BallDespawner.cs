using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDespawner : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Throwable"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
