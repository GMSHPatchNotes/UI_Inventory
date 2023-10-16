using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IPointerDownHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // 아이템을 클릭하면 선택합니다.
        canvasGroup.alpha = 0.6f; // 선택된 아이템을 반투명하게 만들 수 있습니다.
    }

    public void OnDrag(PointerEventData eventData)
    {
        // 아이템을 드래그하면 이동합니다.
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // 아이템 이동 완료 후 선택 해제
        canvasGroup.alpha = 1.0f; // 선택 효과 제거

        // 아이템을 이동한 슬롯에 따라 어떤 작업을 수행할 수 있습니다.
        // 예를 들어, 다른 슬롯으로 이동한 경우 아이템 이동 작업을 수행하거나 슬롯 정보를 업데이트할 수 있습니다.
    }
}