namespace Player
{
    public class BladeRunner : Human
    {
        public BladeRunner(DataLibrary.Room startPosition) : base(startPosition) { }

        public override void Fight(object target)
        {
            if (this.health < 0)
            {
                return;
            }

            base.Fight(target);

            var aiTarget = (AI)target;

            if (aiTarget != null)
            {
                aiTarget.Health -= 1;
            }
        }

        public override void Move(Enums.CardinalDirection direction)
        {
            base.Move(direction);
        }
    }
}
