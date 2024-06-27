using UnityEngine;

public class FiringPoint : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 1000f;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireProjectile();
        }
    }

    private void FireProjectile()
    {
        //create refrence to hold instantiated object
        GameObject projectileInstance;
        projectileInstance = Instantiate(projectilePrefab, transform.position, transform.rotation);
        //get rigidbody and add force
        projectileInstance.GetComponent<Rigidbody>().AddForce(transform.forward * projectileSpeed);

    }
}
