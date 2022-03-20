using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hyperlink : MonoBehaviour
{
    public void RateSite() 
    {
        Application.OpenURL("https://assetstore.unity.com/");
    }

        public void RatePolicy() 
    {
        Application.OpenURL("https://www.youtube.com/watch?v=L3Mg6lk6yyA");
    }
}
