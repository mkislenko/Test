using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPhysicsManager : MonoBehaviour {

    public delegate void CollisionEnter(MyCollider other);
    public event CollisionEnter OnCollisionEnter;

 
}
