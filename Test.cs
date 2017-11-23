using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Drmaa;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Session.Init();
            var templates = Enumerable.Range(0, 10).Select(n => {
                var jt = Session.AllocateJobTemplate();
                jt.JobName = $"test_job_{n}";
                jt.RemoteCommand = "sleep";
                jt.Arguments = new string[]{"10", };
                jt.WorkingDirectory = "/home/nprian/tmp";
                jt.OutputPath = $":/home/nprian/tmp/{n}.txt";
                jt.ErrorPath = $":/home/nprian/tmp/{n}.txt";
                jt.NativeSpecification = " -pe make 22";
                return jt;
            });
            
            var executor = new DrmaaExecutor(3);
            executor.Execute(templates);
        }
    }
}