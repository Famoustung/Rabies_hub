using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    [SerializeField] private Camera uiCamera;
  [SerializeField] GameObject targetPosition;
  public RectTransform pointerRectTransform;

  public float borderSize = 70f;
  private void Awake()
  {
   // targetPosition = new Vector3(27.85f, 15.65f);
   // pointerRectTransform = transform.Find("Pointer").GetComponent<RectTransform>();
    
  }

  private void Update()
  {
      Vector3 toPosition = targetPosition.transform.position;
      Vector3 fromPosition = Camera.main.transform.position;
      fromPosition.z = 0f;
      Vector3 dir = (toPosition - fromPosition).normalized;
      float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) % 360;
      pointerRectTransform.localEulerAngles = new Vector3(0, 0, angle);
      
      

      Vector3 targetPositionScreenPoint = Camera.main.WorldToScreenPoint(targetPosition.transform.position);
      bool isOffScreen = targetPositionScreenPoint.x <= borderSize || targetPositionScreenPoint.x >= Screen.width - borderSize
                                                          || targetPositionScreenPoint.y <= borderSize
                                                          || targetPositionScreenPoint.y >= Screen.height - borderSize;
      
      Debug.Log(isOffScreen + "" + targetPositionScreenPoint);

      if (isOffScreen)
      {
          Vector3 cappedTagetScreenPosition = targetPositionScreenPoint;
          if (cappedTagetScreenPosition.x <= borderSize)
          {
              cappedTagetScreenPosition.x = borderSize;
          }

          if (cappedTagetScreenPosition.x >= Screen.width - borderSize)
          {
              cappedTagetScreenPosition.x = Screen.width - borderSize;
          }

          if (cappedTagetScreenPosition.y <= borderSize)
          {
              cappedTagetScreenPosition.y = borderSize;
          }

          if (cappedTagetScreenPosition.y >= Screen.height - borderSize)
          {
              cappedTagetScreenPosition.y = Screen.height - borderSize;
          }


          Vector3 PointerWorldPosition = uiCamera.ScreenToWorldPoint(cappedTagetScreenPosition);
          pointerRectTransform.position = PointerWorldPosition;
          pointerRectTransform.localPosition = new Vector3(pointerRectTransform.localPosition.x,
              pointerRectTransform.localPosition.y, 0f);

      }
  }
}

