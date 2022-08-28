# Kogane DOTween Extension Methods

DOTween の拡張メソッド

## 使用例

```csharp
using DG.Tweening;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        // DORotate と DOLocalRotate で X / Y / Z のみを設定できる拡張メソッド
        transform.DORotateX( 1, 1 );
        transform.DORotateY( 1, 1 );
        transform.DORotateZ( 1, 1 );
        transform.DOLocalRotateX( 1, 1 );
        transform.DOLocalRotateY( 1, 1 );
        transform.DOLocalRotateZ( 1, 1 );

        // GameObject 型で Transform 型の拡張メソッドを呼び出せるようにする拡張メソッド
        gameObject.DOMoveX( 1, 1 );
        gameObject.DOMoveY( 1, 1 );
        gameObject.DOMoveZ( 1, 1 );

        var sequence = DOTween.Sequence();

        var t1 = gameObject.DOMoveX( 1, 1 );
        var t2 = gameObject.DOMoveY( 1, 1 );
        var t3 = gameObject.DOMoveZ( 1, 1 );

        var tweens = new[] { t1, t2, t3 };

        // Sequence に複数の Tween を同時に登録できる拡張メソッド
        sequence.AppendRange( tweens );
        sequence.InsertRange( 0, tweens );
        sequence.JoinRange( tweens );
        sequence.PrependRange( tweens );

        // メソッドチェーンで Sequence に登録できる拡張メソッド
        gameObject.DOMoveX( 1, 1 ).Append( sequence );
        gameObject.DOMoveX( 1, 1 ).Insert( sequence, 0 );
        gameObject.DOMoveX( 1, 1 ).Join( sequence );
        gameObject.DOMoveX( 1, 1 ).Prepend( sequence );

        // 条件をみたす場合のみ SetDelay する拡張メソッド
        gameObject.DOMoveX( 1, 1 ).SetDelayIf( true, 1 );
    }
}
```