namespace Factory.Models
{
  public class EngineerMachine
  {
    public int EnginnerMachineId { get; set; }
    public int MachineId { get; set; }
    public int EngineerId { get; set; }
    public virtual Engineer Engineer { get; set; }
    public virtual Machine Machine { get; set; }
  }
}