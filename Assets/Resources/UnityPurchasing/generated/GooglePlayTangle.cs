#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("adsrn4Qns8zGomOjLll9ARVQ3wHJSkRLe8lKQUnJSkpL2CgnFR847sUxFNnS0uvs573t0c4FIXrPB4txaYmq7wdY4mOiXdgzom3sS2hFwjI1xNi7Hf7Jq1HAnwnkGUhRllLOwfKDpYBix3XWqygt04T003FXUb2DJKeZ3wpQSw4AnYy5kRC2Oaxy1M8+KB+lI6CnO/HIK2PrZFFEmU5WTZibyNDli32GBuQwDnX7PI6bJU5Gdy20hteqElWpujzPEKz0TZ1gnPdr/hEyG2S61V7DGUQywX4cgojnyRvt5fFrrtl1tEM5BKt99btHgRRMe8lKaXtGTUJhzQPNvEZKSkpOS0iHngWsa2/05tgcrQScjf0oHHQtsxeHQK4tOMQUDElISktK");
        private static int[] order = new int[] { 11,1,6,10,5,7,9,12,13,13,10,12,12,13,14 };
        private static int key = 75;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
