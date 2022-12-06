using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labs {
    public class GenericFactory<T> : MonoBehaviour where T: MonoBehaviour {
        [SerializeField] private T _prefab;

        public T GetNewInstance(int x) {
            return Instantiate(_prefab, new Vector3(x, 10, 0), Quaternion.identity);
        }
    }
}
