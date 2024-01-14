using System;
using UnityEngine;
using UnityEngine.UI;

public class showuponceaday : MonoBehaviour
{
    public Image fill; //框
    private string currentDate2; // 用於保存上一次執行的日期的 PlayerPrefs 鍵值


    private void Awake()
    {
      
        string daya = PlayerPrefs.GetString("日期", " ");
        currentDate2 = DateTime.Now.ToString("MMdd");
        if (daya != currentDate2)
        {
            fill.color = new Color(fill.color.r, fill.color.g, fill.color.b, 0f);
            PlayerPrefs.SetString("日期", currentDate2);
            PlayerPrefs.Save();
        }
    }

}
