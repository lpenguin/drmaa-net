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
            var jt = new JobTemplate();
            jt.JobName = "awesome_job";
            jt.RemoteCommand = args[0];
            jt.Arguments = args.Skip(1).ToArray();
            Console.WriteLine(args[0]);
            Console.WriteLine(string.Join(", ", args.Skip(1).ToArray()));
            var jobId = jt.Submit();

            while(true){
                var status = Session.JobStatus(jobId);
                Console.WriteLine(status);
                Thread.Sleep(1000);
            }
        }
    }
}