using UnityEngine;

public class Spawner : MonoBehaviour
{
    // ＝＝＝ 変数の宣言 ＝＝＝＝＝＝＝
    // ※変数の宣言は"Class内"で行う
    // ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
    public float coolTime = 1.0f;       // 出現の待ち時間
    public GameObject prefab = null;    // 出現させたいプレハブ
    public float coolTimer = 0.0f;      // 待ち時間のタイマー

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1秒間に1増える時間
        coolTimer += Time.deltaTime;

        if ( coolTime < coolTimer )
        {
            // プレハブを出現させる
            Instantiate(prefab);

            // タイマーを0に戻す
            coolTimer = 0;
        }
    }
}
