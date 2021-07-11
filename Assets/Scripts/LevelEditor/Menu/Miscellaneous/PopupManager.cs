
using System;

using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour {

    public static PopupManager instance;
    public void Awake () {

        instance = this;
    }

    public GameObject popupObject, ynPopupObject;

    public void OnYes () {

        ynPopupObject.SetActive(false);
        yesCall();
    }
    public void OnNo () {

        ynPopupObject.SetActive(false);
        noCall();
    }

    public static Action yesCall, noCall;

    public Text ynPopupTitle, ynPopupContent;
    public static void YesNoPopup (string title, string content, Action yesMethod, Action noMethod) {

        yesCall = yesMethod; noCall = noMethod;

        instance.ynPopupObject.SetActive(true);
        instance.ynPopupTitle.text = title;
        instance.ynPopupContent.text = content;
    }
    public static void YesNoPopup (string title, string content, Action yesMethod) {

        yesCall = yesMethod; noCall = instance.EmptyMethod;

        instance.ynPopupObject.SetActive(true);
        instance.ynPopupTitle.text = title;
        instance.ynPopupContent.text = content;
    }

    private void EmptyMethod () {}


    public Text popupTitle, popupContent;
    public static void Popup (string title, string content) {

        instance.popupObject.SetActive(true);
        instance.popupTitle.text = title;
        instance.popupContent.text = content;
    }
}
