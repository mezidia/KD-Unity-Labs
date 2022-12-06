using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteristics : MonoBehaviour
{
    [field:SerializeField]
    public float Health {get; private set;} = 10f;
    [field:SerializeField]
    public float Power {get; private set;} = 10f;
}
