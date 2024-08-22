using Unity.Entities;
using UnityEngine;

public class DogMono : MonoBehaviour
{
    public float moveSpeed = 1f;
}

public class DogBaker : Baker<DogMono>
{
    public override void Bake(DogMono authoring)
    {
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new MoveSpeed { moveSpeed = authoring.moveSpeed });
    }
}
