using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulltetPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)){
           Shoot(); 
        }
    }

    void Shoot(){
        Instantiate(bulltetPrefab,firePoint.position, firePoint.rotation);
    }
}
