using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitDiffApi.Data
{
    public class GetData
    {
        public IActionResult GetCommit(string oid)
        {
            CommitResponse commit = new CommitResponse
            {
                Oid = "a1bf367b3af680b1182cc52bb77ba095764a11f9",
                Message = "repo-updater: Use config value repoListUpdateInterval (#14983)\n\nThis value was previously used to specify how frequently we would sync\r\nwith code hosts so it makes sense to reuse it to set a lower bound on\r\nhow often we sync now that we have backoff logic.",
                Author = new AuthorInfo
                {
                    Name = "Ryan Slade",
                    Date = DateTime.Parse("2020-10-22T16:45:31+02:00"),
                    Email = "ryanslade@gmail.com"
                },
                Committer = new CommitterInfo
                {
                    Name = "GitHub",
                    Date = DateTime.Parse("2020-10-22T16:45:31+02:00"),
                    Email = "noreply@github.com"
                },
                Parents = new List<ParentCommit>
            {
                new ParentCommit
                {
                    Oid = "89600bf602242ef66a741589b5bf784e378e5ead"
                }
            }

            };
            return new JsonResult(commit);

        }
    }
}
