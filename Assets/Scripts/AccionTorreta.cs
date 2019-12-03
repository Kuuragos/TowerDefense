using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionTorreta : MonoBehaviour
{
    public Transform target, dirBalas;
    public GameObject prefabBala;
    public float rango = 10f;
    public float fireRate = 1f;
    public float fireCD;
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemigosEscena = GameObject.FindGameObjectsWithTag("Enemy");
        float identifyEnemy = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemigosEscena)
        {
            float rotateDistance = Vector3.Distance(transform.position, enemy.transform.position);

            if (rotateDistance < identifyEnemy)
            {
                identifyEnemy = rotateDistance;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && identifyEnemy <= rango)
        {
            target = nearestEnemy.transform;

        }
        else
        {
            target = null;

        }
    }
    void Update()
    {
        if (target == null)
            return;
        if (fireCD <= 0)
        {
            Shoot();
            fireCD = 1f / fireRate;
        }
        fireCD -= Time.deltaTime;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, rango);
    }
    void Shoot()
    {
        GameObject dirBala = (GameObject) Instantiate(prefabBala, dirBalas.position, dirBalas.rotation);
        Balas bullet = dirBala.GetComponent<Balas>();
        if (bullet != null)
        {
            bullet.Skeek(target);
        }
    }
    private void FixedUpdate()
    {
        transform.LookAt(target);
    }
}
