using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class Shop_slot : MonoBehaviour
{
    [SerializeField] Goods goods;
    [SerializeField] Button purchase_btn;
    [SerializeField] Text purchase_text;
    [SerializeField] GameObject fail;

    [Header("Cache")]
    private IStoreController storeController; //구매 과정을 제어하는 함수 제공자
    private IExtensionProvider storeExtensionProvider; //여러 플랫폼을 위한 확장 처리 제공자

    private void OnEnable()
    {
        
    }

    private void UI_update()
    {
        if (goods.is_purchase)
        {
            purchase_btn.interactable = false;
            purchase_text.text = "구매 완료";
        }
        else
        {
            purchase_btn.interactable = true;
            purchase_text.text = "구매 가능";
        }
    }
    public void Buy_goods() //btn등록
    {
    }


}
