using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labs {
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private CrabFactory _crabFactory;
        [SerializeField] private FierceToothFactory _ftFactory;
        [SerializeField] private PinkStarFactory _psFactory;

        void Start()
        {
            var crab_prefab = _crabFactory.GetNewInstance();
            // var cr_prefab = _crabFactory.GetNewInstance();
            // var ft_prefab = _ftFactory.GetNewInstance();
            // var ps_prefab = _psFactory.GetNewInstance();
        }

        // Update is called once per frame
        void Update()
        {
            var crab_prefab = _crabFactory.GetNewInstance();
        }
    }
}
