namespace PotsAndPotions.Core.Engine
{
    public interface ITurn
    {
        void DoTurn(IList<PlayerScope> playerScopes);
    }
}