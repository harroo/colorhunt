
using UnityEngine;

public class FocusController : MonoBehaviour {

    public SmoothFollow sfollow;

    public void SetFocus (Transform target) {

        sfollow.target = target;
    }
}
