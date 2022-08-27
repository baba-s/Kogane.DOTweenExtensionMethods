using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Kogane
{
    public static class DOTweenRotateExtensionMethods
    {
        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateX
        (
            this Transform self,
            float          endValue,
            float          duration,
            RotateMode     mode = RotateMode.Fast
        )
        {
            return self.DORotate
            (
                endValue: new Vector3( endValue, 0, 0 ),
                duration: duration,
                mode: mode
            );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateY
        (
            this Transform self,
            float          endValue,
            float          duration,
            RotateMode     mode = RotateMode.Fast
        )
        {
            return self.DORotate
            (
                endValue: new Vector3( 0, endValue, 0 ),
                duration: duration,
                mode: mode
            );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateZ
        (
            this Transform self,
            float          endValue,
            float          duration,
            RotateMode     mode = RotateMode.Fast
        )
        {
            return self.DORotate
            (
                endValue: new Vector3( 0, 0, endValue ),
                duration: duration,
                mode: mode
            );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotateX
        (
            this Transform self,
            float          endValue,
            float          duration,
            RotateMode     mode = RotateMode.Fast
        )
        {
            return self.DOLocalRotate
            (
                endValue: new Vector3( endValue, 0, 0 ),
                duration: duration,
                mode: mode
            );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotateY
        (
            this Transform self,
            float          endValue,
            float          duration,
            RotateMode     mode = RotateMode.Fast
        )
        {
            return self.DOLocalRotate
            (
                endValue: new Vector3( 0, endValue, 0 ),
                duration: duration,
                mode: mode
            );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotateZ
        (
            this Transform self,
            float          endValue,
            float          duration,
            RotateMode     mode = RotateMode.Fast
        )
        {
            return self.DOLocalRotate
            (
                endValue: new Vector3( 0, 0, endValue ),
                duration: duration,
                mode: mode
            );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateX
        (
            this GameObject self,
            float           endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DORotateX( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateY
        (
            this GameObject self,
            float           endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DORotateY( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotateZ
        (
            this GameObject self,
            float           endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DORotateZ( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotateX
        (
            this GameObject self,
            float           endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DOLocalRotateX( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotateY
        (
            this GameObject self,
            float           endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DOLocalRotateY( endValue, duration, mode );
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotateZ
        (
            this GameObject self,
            float           endValue,
            float           duration,
            RotateMode      mode = RotateMode.Fast
        )
        {
            return self.transform.DOLocalRotateZ( endValue, duration, mode );
        }
    }
}