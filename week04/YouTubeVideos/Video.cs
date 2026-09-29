class Video{
    public string _name;
    public string _author;
    public double _length;
    public List<Comment> _comment = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int NumberOfComments()
    {
        return _comment.Count();
    }
}