using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab = null;
    [SerializeField] float force = 0f;
    [SerializeField] Vector3 offset = Vector3.zero;

    public void Explosion()
    {
        GameObject clone = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Rigidbody[] rb = clone.GetComponentsInChildren<Rigidbody>();
        for(int i = 0; i < rb.Length; ++i)
        {
            rb[i].AddExplosionForce(force, transform.position + offset, 10f);
        }
        gameObject.SetActive(false); 
    }

    public void Reset()
    {
        Destroy(explosionPrefab);
    }
}
