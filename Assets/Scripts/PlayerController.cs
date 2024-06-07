using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera;

    [Space]

    public GameObject gun;

    [Space]

    public float moveSpeed = 10.0f;
    private Vector3 currentMoveDir = Vector2.zero;

    public float mouseSensitivity = 1.0f;
    public float maxYAngle = 90;
    private Vector2 currentMouseInput = Vector2.zero;

    private void Start()
    {
        SetCursorLock(true);
    }

    private void Update()
    {
        InputUpdate();
        CameraUpdate();
        GunUpdate();
    }

    private void SetCursorLock(bool isLock)
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = !isLock;
    }

    private void InputUpdate()
    {
        MoveInputUpdate();
        RotateInputUpdate();
        ShootInputUpdate();
    }

    private void MoveInputUpdate()
    {
        currentMoveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Move();
    }

    private void RotateInputUpdate()
    {
        currentMouseInput = Vector3.right * Input.GetAxis("Mouse X") + Vector3.up * (Input.GetAxis("Mouse Y") + currentMouseInput.y);
        Rotate();
    }

    private void ShootInputUpdate()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Shoot");
        }
    }

    private void Move()
    {
        transform.position += transform.rotation * currentMoveDir * moveSpeed * Time.deltaTime;
    }

    private void Rotate()
    {
        transform.eulerAngles += Vector3.up * currentMouseInput.x * mouseSensitivity;
    }

    private float GetMouseYAngle()
    {
        return -Mathf.Clamp(currentMouseInput.y, -maxYAngle, maxYAngle + 1);
    }

    private void CameraUpdate()
    {
        playerCamera.transform.eulerAngles = new Vector3(GetMouseYAngle(), transform.eulerAngles.y, 0);
    }

    private void GunUpdate()
    {
        gun.transform.localEulerAngles = new Vector3(GetMouseYAngle(), 0, 0);
    }
}
