using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class XRUIButtonRayCheck : MonoBehaviour
{
    [SerializeField] private XRRayInteractor uiRayInteractor;
    [SerializeField] private InputActionReference primaryButtonAction;

    private void OnEnable()
    {
        primaryButtonAction.action.performed += TriggerButtonClick;
    }

    private void OnDisable()
    {
        primaryButtonAction.action.performed -= TriggerButtonClick;
    }

    private void TriggerButtonClick(InputAction.CallbackContext context)
    {
        // 检测当前射线是否命中UI元素
        if (!uiRayInteractor.TryGetCurrentUIRaycastResult(out var uiHit)) return;
        // 从命中的对象往上找对应的Button组件，适配按钮上挂了子物体文本、图标的情况
        Button targetButton = uiHit.gameObject.GetComponentInParent<Button>();
        // 只有按钮存在且处于可交互状态才触发
        if (targetButton != null && targetButton.interactable)
        {
            targetButton.onClick.Invoke();
            // 可选：触发按钮的点击状态反馈，和鼠标点击的视觉效果一致
            targetButton.OnPointerClick(new PointerEventData(EventSystem.current));
        }
    }
}
