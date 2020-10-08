using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainInapp : MonoBehaviour
{
    [SerializeField]
    private Text textLog = null;

    private void Start()
    {
        // 없어도됨
        textLog.text = "결제 초기화중";
    }

    private void Update()
    {
        // 없어도됨
        if (UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.StoreController == null ||
            UnityEngine.Purchasing.CodelessIAPStoreListener.Instance.ExtensionProvider == null)
        {

        }
        else
        {
            textLog.text = "결제 준비 완료";
        }
    }

    public void ButtonPurchaseStart()
    {
        // 없어도됨
        textLog.text = "결제 진행중";
    }

    public void callbackPruchaseSuccess()
    {
        textLog.text = "결제 성공";
    }

    public void callbackPurchaseFailed()
    {
        textLog.text = "결제 실패";
    }
}
