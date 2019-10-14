using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 20;
        array[1] = 10;
        array[2] = 60;
        array[3] = 90;
        array[4] = 50;

        // 配列の要素をすべて表示する
        for (int i = 0; i < 5; i++)

        {
            Debug.Log(array[i]);
        }

        for (int i =4;  0 <=i ; i--)

        {
            Debug.Log(array[i]);
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }
}