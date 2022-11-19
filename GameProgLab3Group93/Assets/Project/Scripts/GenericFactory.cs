using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labs {
    public class GenericFactory<T> : MonoBehaviour where T: MonoBehaviour {
        [SerializeField] private T _prefab;
        private int n = 0;

        public T GetNewInstance() {
            return Instantiate(_prefab);
        }
    }
}