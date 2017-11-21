namespace DrmaaNet{
    public class Session{
        public Session(string contact){
            DrmaaWrapper.Init(contact);
        }

        public string RunJobTemplate(JobTemplate jobTemplate){
            return DrmaaWrapper.RunJob(jobTemplate.instance);
        }

        public Status JobStatus(string jobId){
            return DrmaaWrapper.JobPs(jobId);
        }

        public void JobControl(string jobId, Action action){
            DrmaaWrapper.Control(jobId, action);
        }
    }
}