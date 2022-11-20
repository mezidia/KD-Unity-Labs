using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labs {
    public class Crab : MonoBehaviour {
        public float speed;
        public float within_range;
        public Transform target;
        
        void Start()
        {
            target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }
 
        public void Update() {
            float distance = Vector3.Distance(transform.position, target.position);
            if (distance <= within_range) {   
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            }
        }
    }
}