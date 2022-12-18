
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 0.5f;

    public Camera camfps;

    public GameObject impact;

    private float nextTimeToFire = 0f;



    public AudioSource audioSource;
    public AudioClip gunshotSound;

    void Start()
    {
        // Get a reference to the Audio Source component
        audioSource = GetComponent<AudioSource>();
    }







    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            audioSource.PlayOneShot(gunshotSound);
            Shoot();
        }

        void Shoot()
        {
          
            RaycastHit hit;
            if (Physics.Raycast(camfps.transform.position,camfps.transform.forward, out hit, range))
            {
               Enemy target = hit.transform.GetComponent<Enemy>();
               if (target != null)
                {
                    target.takeDmg(damage);
                }
                Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
            }

        }
        
    }
}
