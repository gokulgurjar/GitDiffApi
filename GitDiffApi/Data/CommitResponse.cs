namespace GitDiffApi.Data
{
    public class CommitResponse
    {
        public string Oid { get; set; }

        public string Message { get; set; }

        public AuthorInfo Author { get; set; }

        public CommitterInfo Committer { get; set; }

        public List<ParentCommit> Parents { get; set; }
    }

    public class AuthorInfo
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Email { get; set; }
    }

    public class CommitterInfo
    {
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Email { get; set; }
    }

    public class ParentCommit
    {
        public string Oid { get; set; }
    }

}
