using StarterAssets;
using UnityEngine;


public class Wepon : MonoBehaviour
{
    // get the particle system
    [SerializeField] ParticleSystem MuzzelFlash;
    [SerializeField] int damage = 1;

    StarterAssetsInputs starterAssetsInputs;

    void Awake()
    {
        // get our parents Input component from our scene
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        ShootingSystume();
    }

    void ShootingSystume()
    {
        // if the Shoot is true then we do raycast
        if (starterAssetsInputs.shoot)
        {
            // play the particle system on shoot
            MuzzelFlash.Play();

            // Make a Raycast hit variable
            RaycastHit hit;

            // Projecting the raycast from main camera location to infinity in the forword direction
            // if the raycast is hitting something, if will do whatever in the if statement
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                // hit will contain the information of the thing or object we collide with
                // with this we get the enemyHealth component from the one hit is colliding with
                // if it has a enemyhealth component that means it can die
                EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
                if (enemyHealth)
                {
                    enemyHealth.TakeDamage(damage);
                }
                // Toggle the shoot back to false
                starterAssetsInputs.ShootInput(false);
            }

        }
    }

}
