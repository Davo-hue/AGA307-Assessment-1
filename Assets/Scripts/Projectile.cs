using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifeTime = 3f;


    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    public void DestroyProjectile()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Target"))
        {
            //change color when hit
            collision.gameObject.GetComponentInChildren<Renderer>().material.color = Color.red;
            //destroy after 1 second
            Destroy(collision.collider.gameObject, 1f);
            //destroy object
            Destroy(this.gameObject);
        }

       
    }

}
