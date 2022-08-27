using System.Collections.Generic;
using DG.Tweening;

namespace Kogane
{
    public static class SequenceExtensionMethods
    {
        public static Sequence AppendRange
        (
            this Sequence      self,
            IEnumerable<Tween> collections
        )
        {
            foreach ( var t in collections )
            {
                self.Append( t );
            }

            return self;
        }

        public static Sequence InsertRange
        (
            this Sequence      self,
            float              atPosition,
            IEnumerable<Tween> collections
        )
        {
            foreach ( var t in collections )
            {
                self.Insert( atPosition, t );
            }

            return self;
        }

        public static Sequence JoinRange
        (
            this Sequence      self,
            IEnumerable<Tween> collections
        )
        {
            foreach ( var t in collections )
            {
                self.Join( t );
            }

            return self;
        }

        public static Sequence PrependRange
        (
            this Sequence      self,
            IEnumerable<Tween> collections
        )
        {
            foreach ( var t in collections )
            {
                self.Prepend( t );
            }

            return self;
        }
    }
}