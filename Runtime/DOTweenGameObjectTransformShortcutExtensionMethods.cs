using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Kogane
{
    public static class DOTweenGameObjectTransformShortcutExtensionMethods
    {
        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOMove( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOMoveX( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOMoveY( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOMoveZ( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOLocalMove( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveX
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOLocalMoveX( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveY
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOLocalMoveY( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMoveZ
        (
            this GameObject self,
            float           endValue,
            float           duration,
            bool            snapping = false
        )
        {
            return ShortcutExtensions.DOLocalMoveZ( self.transform, endValue, duration, snapping );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return ShortcutExtensions.DORotate( self.transform, endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Quaternion, NoOptions> DORotateQuaternion
        (
            this GameObject self,
            Quaternion      endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DORotateQuaternion( self.transform, endValue, duration );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate
        (
            this GameObject self,
            Vector3         endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return ShortcutExtensions.DOLocalRotate( self.transform, endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Quaternion, NoOptions> DOLocalRotateQuaternion
        (
            this GameObject self,
            Quaternion      endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DOLocalRotateQuaternion( self.transform, endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale
        (
            this GameObject self,
            Vector3         endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DOScale( self.transform, endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DOScale( self.transform, endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleX
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DOScaleX( self.transform, endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleY
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DOScaleY( self.transform, endValue, duration );
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScaleZ
        (
            this GameObject self,
            float           endValue,
            float           duration
        )
        {
            return ShortcutExtensions.DOScaleZ( self.transform, endValue, duration );
        }
    }
}