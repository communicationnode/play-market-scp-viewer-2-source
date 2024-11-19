using UnityEngine;

[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
public sealed class SignsOffsetBehavior : MonoBehaviour
{
    public Vector2      OffsetField;  
    public Vector2      ScaleField;
    public Vector2      OffsetSpeed;
    public bool         EnableMove;
    public sbyte        _matIndex;  //���� ���������� ���������, ������� ������ ��� ���������
    private Material    _material;
    private Renderer    _renderer;
    
    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
        _material = GetComponent<MeshRenderer>().materials[_matIndex];
    }
    private void FixedUpdate()
    {
        if (EnableMove)
        {
            _material.mainTextureOffset += OffsetSpeed * 0.02f;
        }
        else
        {
            _material.mainTextureOffset = OffsetField * 0.02f;
        }
        _material.mainTextureScale = ScaleField * 0.02f;
    }
}
