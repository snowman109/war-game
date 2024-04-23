using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    public List<GameObject> pannels;

    // Start is called before the first frame update
    void Start()
    {
        HideAll();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void HideAll()
    {
        foreach (GameObject p in pannels)
        {
            p.SetActive(false);
        }
    }
}
