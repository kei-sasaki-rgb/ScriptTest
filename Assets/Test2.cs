using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃の関数
    public void MagicAttack(int magic)
    {
        if (mp >= magic)
        {
            this.mp -= magic;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);

        }
        else
        {
            Debug.Log("mpが足りないため魔法が使えない");
        }
    }
}

    public class Test2 : MonoBehaviour
    {

        void Start()
        {
            // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

            // 攻撃用の関数を呼び出す
            lastboss.Attack();
            // 防御用の関数を呼び出す
            lastboss.Defence(3);
            // 魔法攻撃用の関数を呼び出す
            lastboss.MagicAttack(5);
            //魔法攻撃を10回繰り返す
            for (int i = 0; i < 10; i++)
            {
                Debug.Log(i);
            lastboss.MagicAttack(5);
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
