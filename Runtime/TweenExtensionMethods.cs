using DG.Tweening;

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

        public static Tween Prepend( this Tween self, Sequence sequence )
        {
            sequence.Prepend( self );
            return self;
        }

        public static T SetDelayIf<T>( this T self, bool conditional, float delay ) where T : Tween
        {
            return conditional ? self.SetDelay( delay ) : self;
        }
    }
}