using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateSkillPannel : MonoBehaviour
{
    private GameObject creator;

    private GameObject skillPannel;

    public GameObject parent;

    public string parentDescription;

    void Start()
    {
        creator = GameObject.Find("Canvas");
        skillPannel = GameObject.Find("SkillPannel");
    }

    public void CreateSkill()
    {
        creator.GetComponent<Creator>().HideAll();
        skillPannel.SetActive(true);
        BackToParent backToParent = skillPannel.GetComponent<BackToParent>();
        Button backButton = skillPannel.GetComponentInChildren<Button>();
        Debug.Log("button=" + backButton);
        TextMeshProUGUI backDescription = backButton.GetComponentInChildren<TextMeshProUGUI>();
        Debug.Log("text=" + backDescription);
        backToParent.parent = parent;
        backDescription.text = parentDescription;
    }
}