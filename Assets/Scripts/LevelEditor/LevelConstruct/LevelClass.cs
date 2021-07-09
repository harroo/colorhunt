
using UnityEngine;

using System.Collections.Generic;

[System.Serializable]
public class Level {

    public List<Element> elements
        =new List<Element>();

    public string metaData_Author_User;
    public string metaData_Author_Machine;
    public string metaData_CreationDate;
}

[System.Serializable]
public class Element {

    public float position_X, position_Y;

    public float scale_X, scale_Y;

    public int type;

    public Element (int type, Transform transform) {

        position_X = transform.position.x;
        position_Y = transform.position.y;

        scale_X = transform.localScale.x;
        scale_Y = transform.localScale.y;

        this.type = type;
    }
}
