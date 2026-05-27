using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Reset()
    {
        GameCounter.value = 0;
    }
}
