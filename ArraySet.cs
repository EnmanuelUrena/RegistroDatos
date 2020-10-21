using System;

namespace POO
{
   public class ArraySet
   {
       private Persona[][] buckets = new Persona[26][];

       public ArraySet()
       {
           for(int i = 0; i < buckets.Length; i++)
           {
               buckets[i] = new Persona[5];
           }
       }
       public bool Add(Persona line)
        {
            if(Contains(line))
            {
                return false;
            }
            bool filledBucket = false;
            int bucketIndex = Math.Abs(line.GetHashCode()) % buckets.Length;
            Persona[] bucket = buckets[bucketIndex];
            for(int i = 0; i < bucket.Length; i++)
            {
                if(bucket[i] == null)
                {
                    bucket[i] = line;
                    filledBucket = true;
                    break;
                }
            }
            if(!filledBucket)
            {
                ExtendBucket(bucketIndex);
                buckets[bucketIndex][bucket.Length] = line;
            }
            return true;
        }

        private void ExtendBucket(int bucketIndex)
        {
            int oldLength = buckets[bucketIndex].Length;
            int newLength = (int)(oldLength * 1.5);
            Persona[] newBucket = new Persona[newLength];
            for(int i = 0; i < oldLength; i++)
            {
                newBucket[i] = buckets[bucketIndex][i];
            }
        }

        public bool Contains(Persona line)
        {
            int bucketIndex = Math.Abs(line.GetHashCode()) % buckets.Length;
            Persona[] bucket = buckets[bucketIndex];
            for(int i = 0; i < bucket.Length; i++)
            {
                if(line.Equals(bucket[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Remove(in Persona toRemove) 
        {
            return false;
        }

        public Persona Get(in Persona search) 
        {
            return null;
        }
   }
}