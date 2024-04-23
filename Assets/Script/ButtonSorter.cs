using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSorter : MonoBehaviour
{
    public int rows = 3; // 行数
    public int columns = 2; // 列数

    void Start()
    {
        // 获取面板的 RectTransform 组件
        RectTransform panelTransform = GetComponent<RectTransform>();

        // 获取面板的宽度和高度
        float panelWidth = panelTransform.rect.width;
        float panelHeight = panelTransform.rect.height;

        // 计算按钮的宽度和高度
        float buttonWidth = panelWidth / columns;
        float buttonHeight = panelHeight / rows;

        // 获取面板中的所有按钮
        Button[] buttons = GetComponentsInChildren<Button>();

        // 设置每个按钮的位置和大小
        for (int i = 0; i < buttons.Length; i++)
        {
            int row = i / columns;
            int column = i % columns;

            RectTransform buttonTransform = buttons[i].GetComponent<RectTransform>();
            buttonTransform.sizeDelta = new Vector2(buttonWidth, buttonHeight);
            float posX = (buttonWidth * column) - (panelWidth / 2f) + (buttonWidth / 2f);
            float posY = (buttonHeight * row) - (panelHeight / 2f) + (buttonHeight / 2f);
            buttonTransform.anchoredPosition = new Vector2(posX, posY);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
