using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// プレイヤークラス
/// ------------------------
/// ・ふるまい
/// 　- キーボードで「移動」操作
/// 　- 敵に当たると「消える」
/// 　- キーボードで「射撃」
/// </summary>
public class Player : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        Movement();     // メソッドを実行
    }


    /// <summary>
    /// 移動するメソッド
    /// </summary>
    public void Movement()
    {
        if(Keyboard.current.upArrowKey.isPressed == true)
        {
            transform.Translate(0f, 5f * Time.deltaTime, 0f);
        }

        if(Keyboard.current.leftArrowKey.isPressed == true)
        {
            transform.Translate(-5f * Time.deltaTime, 0f, 0f);
        }

        if(Keyboard.current.rightArrowKey.isPressed == true)
        {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }

        if(Keyboard.current.downArrowKey.isPressed == true)
        {
            transform.Translate(0, -5f * Time.deltaTime, 0f);
        }
    }

    /// <summary>
    /// 消えるメソッド
    /// </summary>
    public void Dead()
    {
        Destroy( gameObject );
    }


    /// <summary>
    /// 射撃するメソッド
    /// </summary>
    public void Shot()
    {

    }


    /// <summary>
    /// 重なる衝突判定
    /// </summary>
    private void OnTriggerEnter2D( Collider2D collision )
    {
        Debug.Log($"{collision.name} と重なりました。");
    }
}
