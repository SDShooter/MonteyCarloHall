namespace MontyCarloHall.Shared
{
    public class MontyHallModel
    {
        //[StringLength(10, ErrorMessage = "Name is too long.")]
        //public string? Name { get; set; }
        public Boolean PlayerStrategySwitch { get; set;}
        public Boolean PlayerStrategyStay { get; set; }
        public Decimal WinPercent { get; set; }
        public Decimal Wins { get; set; }
        public Decimal Runs { get; set; }

    }
}
