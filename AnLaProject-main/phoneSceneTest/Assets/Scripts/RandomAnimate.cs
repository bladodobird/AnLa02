using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimate : MonoBehaviour
{
    public Animator animator1; // 引用動畫1的Animator或其他控制動畫的組件
    public Animator animator2; // 引用動畫2的Animator或其他控制動畫的組件

    void Start()
    {
        StartCoroutine(PlayRandomAnimation());
    }

    IEnumerator PlayRandomAnimation()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f, 10f)); // 設置時間間隔，可根據需要調整

            int randomAnimation = Random.Range(1, 3); // 生成1或2之間的隨機數
            if (randomAnimation == 1)
            {
                animator1.Play("Animation1"); // 播放動畫1，根據你的實際動畫名稱調整
            }
            else
            {
                animator2.Play("Animation2"); // 播放動畫2，根據你的實際動畫名稱調整
            }
        }
    }
}
