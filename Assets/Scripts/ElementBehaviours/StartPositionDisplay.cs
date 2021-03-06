
 // ♥ StartPositionDisplay.cs

/*

    *  ♥ By Tahlia P. Evlyne, via Teletype ♥ *

    * A modified version of 'FollowParent.cs'.

    * Tailored for the specific purpose of managing the
    * StartPosition-GameObject's position.

*/

// Blah Blah ♥ Unity-Stuffs!

using UnityEngine;

// I'm over commenting this now I can just tell.
// But at least it looks prettyyy!! ♥ ♥ ♥ ♥

public class StartPositionDisplay : MonoBehaviour { // ♥


    // A Reference-Variable for the Parent-Transform.

    private Transform parent ;


    // Called when a GameObject with this Component is instantiated.

    private void Start ( ) { // ♥

        // Assign Parent-Variable for future reference.
        parent = transform.parent ;

        // Disown the Parent-Transform.
        transform.parent = null ;

        // Reset the localScale to be snug.
        transform.localScale = new Vector3 (

            8.0f, 8.0f, 8.0f

        ) ;

    } // ♥


    // Called once per Game-Loop.

    private void Update ( ) { // ♥

        // In the event our Parent-Transform evaporates:
        if ( parent == null )

            // Remove the GameObject to clean up.
            Destroy ( this.gameObject ) ;

        else //Otherwise.

            // Simply sync the position to that of the Parent-Transform.
            transform.position = parent.position ;

    } // ♥

} // ♥
