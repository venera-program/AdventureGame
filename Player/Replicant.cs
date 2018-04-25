namespace Player
{
    public class Replicant : AI
    {
        public Replicant(DataLibrary.Room startPosition) : base(startPosition) { }

        public override void Fight(object target)
        {
            if (this.health < 0)
            {
                return;
            }

            base.Fight(target);

            var humanTarget = (Human)target;

            if (humanTarget != null)
            {
                humanTarget.Health -= 1;
            }
        }

        public override void Move(Enums.CardinalDirection direction)
        {
            base.Move(direction);
        }
    }
}
