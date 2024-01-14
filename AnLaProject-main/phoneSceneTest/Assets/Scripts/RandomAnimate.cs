using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimate : MonoBehaviour
{
    public Animator animator1; // �ޥΰʵe1��Animator�Ψ�L����ʵe���ե�
    public Animator animator2; // �ޥΰʵe2��Animator�Ψ�L����ʵe���ե�

    void Start()
    {
        StartCoroutine(PlayRandomAnimation());
    }

    IEnumerator PlayRandomAnimation()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f, 10f)); // �]�m�ɶ����j�A�i�ھڻݭn�վ�

            int randomAnimation = Random.Range(1, 3); // �ͦ�1��2�������H����
            if (randomAnimation == 1)
            {
                animator1.Play("Animation1"); // ����ʵe1�A�ھڧA����ڰʵe�W�ٽվ�
            }
            else
            {
                animator2.Play("Animation2"); // ����ʵe2�A�ھڧA����ڰʵe�W�ٽվ�
            }
        }
    }
}
