using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private Transform _Circle;
    [SerializeField] private float _CricleSize;

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(_Circle.position, _CricleSize);
    }
}
