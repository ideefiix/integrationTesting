using Microsoft.EntityFrameworkCore;

namespace IntegrationTesting.DataModels.Models;

public class Command
{
    public Guid Id { get; set; }
    public DateTime TimeStamp { get; set; }
    public ActionType Action { get; set; }
}

public enum ActionType
{
    BombDrop,
    MachineGunFire,
    MissileLaunch,
}