using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;

    public UnityEvent OnJumped;
    public UnityEvent OnDied;
    public UnityEvent OnScored;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Rotate();
    }
    private void Jump()
    {
        // �̰� ���� ���� �����ִ� ����̴�
        // rb.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        // ���� �ӷ��� �����ִ� �������
        rb.velocity = Vector2.up * jumpPower;

        OnJumped?.Invoke();
    }
    private void Rotate()
    {
        transform.right = rb.velocity + Vector2.right * moveSpeed;
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnDied?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.DataManager.CurScore++;
        OnScored?.Invoke();
    }
}
