using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelWeaker : MonoBehaviour
{
  
    public GameObject creator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PannelControl()
    {
        creator.GetComponent<Creator>().HideAll();
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
