using System.Runtime.InteropServices;

public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var dominoesList = dominoes.ToList();

        if (dominoesList.Count == 0)
            return true;

        (int left, int right) firstDomino = dominoesList[0];

        var missingDominoes = dominoesList.Skip(1).ToList();

        return TestOptions(firstDomino.left, firstDomino.right, missingDominoes);
         
    }

    private static bool TestOptions(int initial, int openedValue, List<(int left, int right)> missingDominoes)
    {
        if (missingDominoes.Count == 0)
        {
            return openedValue == initial;
        }

        for (int i = 0; i < missingDominoes.Count; i++)
        {
            int newOpenedValue;

            if (missingDominoes[i].right == openedValue)
            {
                newOpenedValue = missingDominoes[i].left;
            }
            else if (missingDominoes[i].left == openedValue)
            {
                newOpenedValue = missingDominoes[i].right;
            }
            else
            {
                continue;
            }

            var newMissingDominoes = missingDominoes.ToList();
            newMissingDominoes.RemoveAt(i);

            if (TestOptions(initial, newOpenedValue, newMissingDominoes))
            {
                return true;
            }

        }

        return false;

    }
}