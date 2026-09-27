class Videos{
    public string _name;
    public string _author;
    public double _length;
    public List<Comments> _comments = new List<Comments>();

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }
}