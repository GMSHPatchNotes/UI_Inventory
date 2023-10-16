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
        // �������� Ŭ���ϸ� �����մϴ�.
        canvasGroup.alpha = 0.6f; // ���õ� �������� �������ϰ� ���� �� �ֽ��ϴ�.
    }

    public void OnDrag(PointerEventData eventData)
    {
        // �������� �巡���ϸ� �̵��մϴ�.
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // ������ �̵� �Ϸ� �� ���� ����
        canvasGroup.alpha = 1.0f; // ���� ȿ�� ����

        // �������� �̵��� ���Կ� ���� � �۾��� ������ �� �ֽ��ϴ�.
        // ���� ���, �ٸ� �������� �̵��� ��� ������ �̵� �۾��� �����ϰų� ���� ������ ������Ʈ�� �� �ֽ��ϴ�.
    }
}