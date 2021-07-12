
using UnityEngine;

using UnityEngine.UI;

public class ElementMenu : MonoBehaviour {

    public ElementSelector elementSelector;

    public Slider scaleSliderX, scaleSliderY;

    public void scaleSliderX_OnChange () {

        elementSelector.SetScaleX(scaleSliderX.value * 8);
    }
    public void scaleSliderY_OnChange () {

        elementSelector.SetScaleY(scaleSliderY.value * 8);
    }

    private int index;

    public void Toggle (bool moveForward) {

        index = index + (moveForward ? 1 : -1);

        index = index < 0 ? ElementTypes.instance.types.Length - 1 : index;
        index = index > ElementTypes.instance.types.Length - 1 ? 0 : index;

        elementSelector.SetElement(index);
    }
}
