using UnityEngine;

/// <summary>
/// 敵クラス
/// ------------------------
/// ・動き
/// 　- 右から左に等速直線運動
/// 　- 画面外に出ると消える
/// </summary>
public class Enemy : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        Movement();

        if( transform.position.x < -15 )
        {   // ★ オブジェクトのx座標が[-15]よりも小さい値になったら...
            Dead();
        }
    }


    /// <summary>
    /// 動くメソッド
    /// </summary>
    public void Movement()
    {
        transform.Translate( -3 * Time.deltaTime, 0, 0 );
    }


    /// <summary>
    /// 消えるメソッド
    /// </summary>
    public void Dead()
    {
        Debug.Log($"[Enemy.cs] { transform.name } が削除されました...");
        Destroy( gameObject );
    }
}
