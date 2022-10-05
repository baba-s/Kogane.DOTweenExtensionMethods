using DG.Tweening;
using UnityEngine;

namespace Kogane
{
    public static class TweenExtensionMethods
    {
        public static Tween Append( this Tween self, Sequence sequence )
        {
            sequence.Append( self );
            return self;
        }

        public static Tween Insert( this Tween self, Sequence sequence, float atPosition )
        {
            sequence.Insert( atPosition, self );
            return self;
        }

        public static Tween InsertFirst( this Tween self, Sequence sequence )
        {
            return self.Insert( sequence, 0 );
        }

        public static Tween Join( this Tween self, Sequence sequence )
        {
            sequence.Join( self );
            return self;
        }

        public static Tween JoinIf( this Tween self, bool condition, Sequence sequence )
        {
            if ( !condition ) return self;
            sequence.Join( self );
            return self;
        }

        public static Tween Prepend( this Tween self, Sequence sequence )
        {
            sequence.Prepend( self );
            return self;
        }

        public static T SetDelayIf<T>( this T self, bool conditional, float delay ) where T : Tween
        {
            return conditional ? self.SetDelay( delay ) : self;
        }

        public static void CompleteIf<T>( this T self, bool condition ) where T : Tween
        {
            if ( !condition ) return;
            self.Complete();
        }

        public static T SetLink<T, TComponent>( this T self, TComponent component )
            where T : Tween
            where TComponent : Component
        {
            return self.SetLink( component.gameObject );
        }
    }
}