using UnityEngine;

public class ClothFixer : MonoBehaviour
{
    void Start()
    {
        var cloth = GetComponent<Cloth>();
        var constraints = cloth.coefficients;

        for (int i = 0; i < constraints.Length; i++)
        {
            // Plane의 상단 가로줄만 고정하는 예시 (0~9번)
            if (i < 10)
            {
                constraints[i].maxDistance = 0f;
            }
            else
            {
                constraints[i].maxDistance = 0.5f;
            }
        }

        cloth.coefficients = constraints;
    }
}
