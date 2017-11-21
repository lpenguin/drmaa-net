using System;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DrmaaNet;

namespace myApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Session session = new Session(null);
            var jt = new JobTemplate();
            jt.JobName = "foobar";
            jt.RemoteCommand = args[0];
            jt.Arguments = args.Skip(1).ToArray();
            Console.WriteLine(args[0]);
            Console.WriteLine(string.Join(", ", args.Skip(1).ToArray()));
            var jobId = session.RunJobTemplate(jt);

            while(true){
                var status = session.JobStatus(jobId);
                Console.WriteLine(status);
                Thread.Sleep(1000);
            }
            // int maxMem = Int32.Parse(args[0]);
            // int incr = Int32.Parse(args[1]);

            // int n = 1;
            // while(true){
            //     // if(n % 1000 == 0){
            //         Console.WriteLine(n);
            //     // }
            //     List< byte[] > a = new List< byte[] >();
            //     for(int i = 0;i < n; i++){
            //         byte[] buffer = new byte[4096];
                    
            //         a.Add(buffer);
            //     }
            //     if(n < maxMem){
            //         n *= incr;
            //     }
                
            // }
        }
    }
}