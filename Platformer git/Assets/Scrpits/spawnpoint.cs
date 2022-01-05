using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour
{
    [SerializeField] private Transform spawnplace;
    [SerializeField] private float spawnpointsize;

    public Transform player;
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(spawnplace.position, spawnpointsize);
    }

    public void respawn()
    {
        player.position = spawnplace.position;
    }
}
