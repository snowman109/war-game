using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToParent : MonoBehaviour
{
    public GameObject parent;
    private GameObject creator;
    // Start is called before the first frame update
    void Start()
    {
        creator = GameObject.Find("Canvas");
    }

    public void GoToParent(){
        creator.GetComponent<Creator>().HideAll();
        parent.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
