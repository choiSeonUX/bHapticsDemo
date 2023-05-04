using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoidUnit : MonoBehaviour
{
    [Header("Info")]
    Boids myBoids;
    List<BoidUnit> neighbours = new List<BoidUnit>();

    Vector3 targetVector;
    Vector3 egoVector;
    float speed;
    float additonalSpeed = 0;
    bool isEnemy;

    MeshRenderer myMeshRenderer; 


}
