using UnityEngine;

public class Spawner : MonoBehaviour
{
    // ＝＝＝ 変数の宣言 ＝＝＝＝＝＝＝
    // ※変数の宣言は"Class内"で行う
    // ＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝
    public float coolTime = 1.0f;       // 出現の待ち時間
    public GameObject prefab = null;    // 出現させたいプレハブ
    public float coolTimer = 0.0f;      // 待ち時間のタイマー

    public float randomYMin = -5.0f;    // Y軸乱数の最小値
    public float randomYMax = 5.0f;     // Y軸乱数の最大値

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
            Vector3 randomPosition = new Vector3(0, 0, 0);              // ランダム座標の変数
            randomPosition.x = 15;                                      // X軸は固定
            randomPosition.y = Random.Range(randomYMin, randomYMax);    // Y軸は乱数

            Vector3 spawnAngles = new Vector3(0, 0, 0);     // 出現時の角度

            // プレハブを出現させる
            // Instantiate( 出現させるオブジェクト情報, 出現座標, 出現角度 )
            Instantiate( prefab, randomPosition, Quaternion.Euler(spawnAngles) );

            // タイマーを0に戻す
            coolTimer = 0;
        }
    }
}
