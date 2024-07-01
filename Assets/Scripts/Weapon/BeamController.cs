using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamController : WeaponController
{
    
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedBeam = Instantiate(weaponData.Prefab);
        spawnedBeam.transform.position = transform.position;
        spawnedBeam.GetComponent<BeamBehaviour>().DirectionChecker(pm.lastMovedVector);
    }
}
