using System;
using UnityEngine;
using UnityEngine.UI;

public class showuponceaday : MonoBehaviour
{
    public Image fill; //��
    private string currentDate2; // �Ω�O�s�W�@�����檺����� PlayerPrefs ���


    private void Awake()
    {
      
        string daya = PlayerPrefs.GetString("���", " ");
        currentDate2 = DateTime.Now.ToString("MMdd");
        if (daya != currentDate2)
        {
            fill.color = new Color(fill.color.r, fill.color.g, fill.color.b, 0f);
            PlayerPrefs.SetString("���", currentDate2);
            PlayerPrefs.Save();
        }
    }

}
