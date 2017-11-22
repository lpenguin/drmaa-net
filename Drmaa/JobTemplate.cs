using System.Text;
using System.Runtime.InteropServices;
using System;

namespace DrmaaNet {
    public class JobTemplate{
        internal DrmaaJobTemplate instance;
        private class Attributes {
            internal static readonly string RemoteCommand = "drmaa_remote_command";
            internal static readonly string WorkingDirectory = "drmaa_wd";
            internal static readonly string NativeSpecification = "drmaa_native_specification";

            internal static readonly string JobName = "drmaa_job_name";

            internal static readonly string JobSubmissionState = "drmaa_js_state";
            internal static readonly string Argv = "drmaa_v_argv";
        };

        public string[] Arguments {
            // get { 
            //     return DrmaaWrapper.GetAttribute(instance, Attributes.RemoteCommand); 
            // }

            set { 
                DrmaaWrapper.SetAttributes(instance, Attributes.Argv, value); 
            }
        }

        public string RemoteCommand {
            get { 
                return DrmaaWrapper.GetAttribute(instance, Attributes.RemoteCommand); 
            }

            set { 
                DrmaaWrapper.SetAttribute(instance, Attributes.RemoteCommand, value); 
            }
        }

        public string JobSubmissionState {
            get { 
                return DrmaaWrapper.GetAttribute(instance, Attributes.JobSubmissionState); 
            }

            set { 
                DrmaaWrapper.SetAttribute(instance, Attributes.JobSubmissionState, value); 
            }
        }

        public string WorkingDirectory {
            get { 
                return DrmaaWrapper.GetAttribute(instance, Attributes.WorkingDirectory); 
            }

            set { 
                DrmaaWrapper.SetAttribute(instance, Attributes.WorkingDirectory, value); 
            }
        }

        public string NativeSpecification {
            get { 
                return DrmaaWrapper.GetAttribute(instance, Attributes.NativeSpecification); 
            }

            set { 
                DrmaaWrapper.SetAttribute(instance, Attributes.NativeSpecification, value); 
            }
        }

        public string JobName {
            get { 
                return DrmaaWrapper.GetAttribute(instance, Attributes.JobName); 
            }

            set { 
                DrmaaWrapper.SetAttribute(instance, Attributes.JobName, value); 
            }
        }


        public JobTemplate(){
            this.instance = DrmaaWrapper.AllocateJobTemplate();
        }
    }
}