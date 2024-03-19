using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 프리팹
    public Transform bulletSpawnPoint; // 총알이 생성될 위치
    public float bulletSpeed = 50f; // 총알 속도

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // 만약 스페이스 키가 눌렸다면
        {
            FireBullet(); // 총알 발사
        }
    }

    void FireBullet()
    {
        // 총알 프리팹을 복제하여 총알 오브젝트 생성
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // 총알에 Rigidbody 컴포넌트 추가
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // 총알의 속도를 설정하여 발사
        bulletRigidbody.velocity = bulletSpawnPoint.forward * bulletSpeed;

        // 일정 시간이 지난 후에 총알을 삭제
        Destroy(bullet, 2f);
    }

}