using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTestScriptt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start normal log");
        Debug.LogWarning("start warning log");
        Debug.LogError("Start error log");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Normal log");
    }
}
