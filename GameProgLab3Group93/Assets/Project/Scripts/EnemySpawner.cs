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
            int n = 5;
            string[] arr = {"crab", "ft", "ps"};
            
            for (int i = 0; i < n; i++) {
                System.Random random = new System.Random();
                int index = random.Next(0, arr.Length);

                switch (arr[index])
                {
                    case "crab":
                        _crabFactory.GetNewInstance(index);
                        break;
                    case "ft":
                        _ftFactory.GetNewInstance(index);
                        break;
                    case "ps":
                        _psFactory.GetNewInstance(index);
                        break;
                } 
            }
        }

        // Update is called once per frame
        void Update() {

        }
    }
}
