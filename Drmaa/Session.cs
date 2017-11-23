namespace Drmaa{
    public class Session{
        public static void Init(string contact=null){
            DrmaaWrapper.Init(contact);
        }

        public static Status JobStatus(string jobId){
            return DrmaaWrapper.JobPs(jobId);
        }

        public static void JobControl(string jobId, Action action){
            DrmaaWrapper.Control(jobId, action);
        }

        public static JobTemplate AllocateJobTemplate(){
            return new JobTemplate(DrmaaWrapper.AllocateJobTemplate());
        }
    }
}