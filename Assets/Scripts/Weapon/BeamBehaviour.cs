using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamBehaviour : ProjectileWeapon
{
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * weaponData.Speed * Time.deltaTime;
    }
}
