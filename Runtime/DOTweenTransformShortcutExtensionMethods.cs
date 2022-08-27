using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Kogane
{
    public static class DOTweenTransformShortcutExtensionMethods
    {
        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOMove( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOMoveX( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOMoveY( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOMoveZ( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOLocalMove( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOLocalMoveX( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOLocalMoveY( endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return self.transform.DOLocalMoveZ( endValue, duration, snapping );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DORotate( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion
        (
            this GameObject self,
            Quaternion      endValue,
            float           duration
        )
        {
            return self.transform.DORotateQuaternion( endValue, duration );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DOLocalRotate( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion
        (
            this GameObject self,
            Quaternion      endValue,
            float           duration
        )
        {
            return self.transform.DOLocalRotateQuaternion( endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale
        (
            this GameObject self,
            Vector3         endValue,
            float           duration
        )
        {
            return self.transform.DOScale( endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return self.transform.DOScale( endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return self.transform.DOScaleX( endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return self.transform.DOScaleY( endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return self.transform.DOScaleZ( endValue, duration );
        }
    }
}