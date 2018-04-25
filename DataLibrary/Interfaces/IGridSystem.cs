namespace DataLibrary
{
    interface IGridSystem<T>
    {
        T[][] GridLayout { get; set; }
        void AddUnit(T newUnit);
        Vector2[] CheckValidNeighbors(T unit);
        void RemoveUnit(T unitToDelete);
    }
}
