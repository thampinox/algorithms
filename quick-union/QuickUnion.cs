using System.Text;

public class QuickUnion
{
    private int[] _id;
    public QuickUnion(int n)
    {
        _id = new int[n];
        for (int i = 0; i < n; i++)
        {
            _id[i] = i;
        }
    }

    public bool Connected(int p, int q)
    {
        return Root(p) == Root(q);
    }

    public void Union(int p, int q)
    {
        int pRoot = Root(p);
        int qRoot = Root(q);

        _id[pRoot] = qRoot;
    }

    public override string ToString()
    {
        var idString = new StringBuilder();

        idString.Append("|");
        foreach (int id in _id)
        {
            idString.Append($"{id}|");
        }

        return idString.ToString();
    }
    private int Root(int k)
    {
        // if (_id[k] == k)
        //     return k;

        // return Root(_id[k]);

        while (k != _id[k])
            k = _id[k];

        return k;
    }
}