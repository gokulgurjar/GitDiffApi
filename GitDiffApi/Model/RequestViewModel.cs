using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GitDiffApi.Models
{
    public class parameters
    {
        public Owner owner { get; set; }
        public Repository repository { get; set; }
        public ParentCommit parentCommit { get; set; }
    }

    [Description("Repository owner.")]
    public class Owner
    {
        [Required]
        //[Description("")]
        //[RegularExpression("^[a-zA-Z0-9-_]+$", ErrorMessage = "Invalid characters in 'owner' parameter.")]
        public string Name { get; set; }
    }

    public class Repository
    {
        public string Name { get; set; }
    }

    public class Signature
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string AvatarUrl { get; set; }
    }

    public class Commit
    {
        public string Oid { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<ParentCommit> Parents { get; set; }
        public Signature Author { get; set; }
        public Signature Committer { get; set; }
    }

    public class ParentCommit
    {
        public string Oid { get; set; }
    }

    public class CombinedFileDifference
    {
        public string ChangeKind { get; set; }
        public FileDetails BaseFile { get; set; }
        public FileDetails HeadFile { get; set; }
        public List<DiffHunk> Hunks { get; set; }
    }

    public class FileDetails
    {
        public string Path { get; set; }
    }

    public class DiffHunk
    {
        public string Header { get; set; }
        public List<DiffLine> Lines { get; set; }
    }

    public class DiffLine
    {
        public int? BaseLineNumber { get; set; }
        public int? HeadLineNumber { get; set; }
        public string Content { get; set; }
    }

}
