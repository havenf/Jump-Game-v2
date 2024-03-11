using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 5) * 50 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Destroy(this.gameObject);
            // Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
    }
}
