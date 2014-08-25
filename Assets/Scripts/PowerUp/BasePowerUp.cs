public class BasePowerUp
{
	public string Name { get; set; }
	public int ActionPoints { get; set; }
	public PowerUpType PowerUpType { get; set; }

	public BasePowerUp()
	{
		Name = "";
		ActionPoints = 1;
		PowerUpType = PowerUpType.None;
	}
}

public enum PowerUpType
{
	Weapon,
	Armor,
	Special,
	Speed,
	None
}