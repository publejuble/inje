using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform bulletSpawnPoint; // �Ѿ��� ������ ��ġ
    public float bulletSpeed = 50f; // �Ѿ� �ӵ�

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // ���� �����̽� Ű�� ���ȴٸ�
        {
            FireBullet(); // �Ѿ� �߻�
        }
    }

    void FireBullet()
    {
        // �Ѿ� �������� �����Ͽ� �Ѿ� ������Ʈ ����
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // �Ѿ˿� Rigidbody ������Ʈ �߰�
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // �Ѿ��� �ӵ��� �����Ͽ� �߻�
        bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;

        // ���� �ð��� ���� �Ŀ� �Ѿ��� ����
        Destroy(bullet, 2f);
    }

}