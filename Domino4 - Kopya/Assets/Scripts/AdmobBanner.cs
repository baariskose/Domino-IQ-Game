using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmobBanner : MonoBehaviour
{
    private BannerView bannerView;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        //this.RequestBanner();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-4931702315582966/5458101776";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
       // this.bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        //AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        //this.bannerView.LoadAd(request);
    }
}
