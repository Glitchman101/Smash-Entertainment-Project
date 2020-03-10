using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float knockbackAmount;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    void Update()
    {
            Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            muzzleFlash.Play();
            RaycastHit Hit;
            if (Physics.Raycast(transform.position, fpsCam.transform.forward, out Hit, range))
            {
                Debug.Log(Hit.collider.name);

                Target target =  Hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                }
            }
        }
    }
}
