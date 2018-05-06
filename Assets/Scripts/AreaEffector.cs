using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    private float time;
    private bool arena;
    public GameObject areaEffector;

	// Use this for initialization
	void Start () {
        arena = false;
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time > 5)
        {
            areaEffector.SetActive(arena);

            time = 0;

            arena = !arena;

        }


	}
}
