using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{
    private Transform target;
    public float speed = 70f;
    public int daño = 5;

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
        transform.LookAt(target);
    }

    void GolpeTarget()
    {
        Daño(target);
        Destroy(target.gameObject);
    }
    private void Daño(Transform enemigo)
    {
        MovimientoEnemigo movEne = enemigo.GetComponent<MovimientoEnemigo>();
        if (movEne != null)
        {
            movEne.RecibirDaño(daño);
        }
    }
}
