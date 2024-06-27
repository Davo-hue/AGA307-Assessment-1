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

}
