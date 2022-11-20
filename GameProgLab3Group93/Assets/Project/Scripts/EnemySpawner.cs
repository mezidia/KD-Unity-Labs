using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labs {
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private CrabFactory _crabFactory;
        [SerializeField] private FierceToothFactory _ftFactory;
        [SerializeField] private PinkStarFactory _psFactory;

        void Start() {      
            _crabFactory.GetNewInstance();
            _ftFactory.GetNewInstance();
            _psFactory.GetNewInstance();

        }

        // Update is called once per frame
        void Update() {

        }
    }
}
