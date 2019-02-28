using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithDelay : MonoBehaviour {
    [SerializeField]
    private float _delay;
	void Start () {
        Destroy(gameObject, _delay);
	}

}
