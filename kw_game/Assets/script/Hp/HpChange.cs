using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // 오브젝트의 스프라이트 렌더러
    public Color angryColor = Color.red; // 화난 색상
    private Color originalColor; // 기본 색상
    public BHUI bhp;
    public BossShooter bossShooter;
    public EnemyShooter Es;

    void Start()
    {
        // 오브젝트의 초기 색상을 기억합니다.
        originalColor = spriteRenderer.color;
        // BossShooter 컴포넌트를 가져옵니다.
        bossShooter = GetComponent<BossShooter>();
    }

    void Update()
    {
        if (bhp.bosshp == 1)
        {
            // 목숨이 한 개 남았을 때 색상을 화난 색상으로 변경합니다.
            spriteRenderer.color = angryColor;

            // BossShooter 컴포넌트를 활성화합니다.
            bossShooter.ActivateShooting();
        }
    }
}