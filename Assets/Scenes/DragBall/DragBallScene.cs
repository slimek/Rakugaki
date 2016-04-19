using UnityEngine;
using System.Collections;

public class DragBallScene : MonoBehaviour
{
    private UIRoot m_root;


    void Start ()
    {
        m_root = GetComponent< UIRoot >();

        var child = gameObject.AddChild();
        var texture = child.AddComponent< UITexture >();
        texture.mainTexture = Resources.Load< Texture2D >( "SolidYellow" );

        texture.leftAnchor.target = m_root.transform;
        texture.leftAnchor.relative = 0;

        texture.rightAnchor.target = m_root.transform;
        texture.rightAnchor.relative = 1;

        texture.bottomAnchor.target = m_root.transform;
        texture.bottomAnchor.relative = 0;

        texture.topAnchor.target = m_root.transform;
        texture.topAnchor.relative = 1;
    }
    
    void Update ()
    {
    
    }
}
