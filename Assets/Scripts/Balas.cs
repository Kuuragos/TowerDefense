using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;

    public void Skeek(Transform targetB)
    {
        target = targetB;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 magni = target.position - transform.position;
        float disThisFrame = speed * Time.deltaTime;

        if (magni.magnitude <= disThisFrame)
        {
            GolpeTarget();
            return;
        }
        transform.Translate(magni.normalized * disThisFrame, Space.World);
    }

    void GolpeTarget()
    {
        Destroy(gameObject);
        Destroy(target.gameObject);
    }
}
