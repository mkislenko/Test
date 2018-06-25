using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCollider : Component {

    public bool isTrigger = false;

    [SerializeField]
    protected PhysicMaterial physicMaterial;
}
