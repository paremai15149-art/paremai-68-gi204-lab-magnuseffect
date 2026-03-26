using UnityEngine;
using UnityEngine.InputSystem;
public class AngularVelocityControl : MonoBehaviour
{
    public float angularSpeed = 1f; // �����繡����ع
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed) // �ӧҹ����͡����� A ��ҧ
        {
            _rb.angularVelocity = new Vector3(0, angularSpeed, 0); // ����¹��������᡹ Y �����ҵ����
        }
        else
        {
            _rb.angularVelocity = Vector3.zero;
        }
    }
}
