using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class NewBehaviourScript : MonoBehaviour
{
    public StarterAssetsInputs _input;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot()
    {
        Debug.Log("shoot!");
    }
}