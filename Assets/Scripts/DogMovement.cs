using Unity.Entities;
using Unity.Transforms;

public partial struct DogMovement : ISystem
{
    public void OnUpdate (ref SystemState state)
    {
        float deltaTime = SystemAPI.Time.DeltaTime;

        foreach(var (transform, speed) in SystemAPI.Query<RefRW<LocalTransform>, RefRO<MoveSpeed>>())
        {
            transform.ValueRW.Position.y += speed.ValueRO.moveSpeed * deltaTime;
        }
    }
}
