using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnZombies1 : Interactable

{

    public GameObject zombie;

    public void ZombieSpawner1()
    {
        Instantiate(zombie, new Vector3(-267, 2, -857), Quaternion.identity);
    }
}
