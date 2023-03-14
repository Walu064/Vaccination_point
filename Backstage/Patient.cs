namespace Vaccination_point_v3_frame.Backstage
{
    enum PreparationType
    {
        MODERNA, ASTRAZENECA, SPUTNIK, JJ, PFIZER
    }

    class Patient
    {
        private readonly string patient_id;
        private int patient_covid19_testResult;
        private readonly int patient_priority;
        private readonly PreparationType preparation_type;

        public Patient(string id, int preparation, int priority)
        {
            this.patient_id = id;
            switch(preparation)
            {
                case 1:
                    this.preparation_type = PreparationType.MODERNA;
                    break;
                case 2:
                    this.preparation_type = PreparationType.ASTRAZENECA;
                    break;
                case 3:
                    this.preparation_type = PreparationType.SPUTNIK;
                    break;
                case 4:
                    this.preparation_type = PreparationType.JJ;
                    break;
                case 5:
                    this.preparation_type = PreparationType.PFIZER;
                    break;
            }
            this.patient_priority = priority;
            this.patient_id += ("_" + patient_priority.ToString());
        }

        public void SetPatientCovid19TestResult(int r)
        {
            this.patient_covid19_testResult = r;
        }

        public string GetPatientId()
        {
            return this.patient_id;
        }

        public PreparationType GetPreferedPreparation()
        {
            return this.preparation_type;
        }

        public int GetPatientPriority()
        {
            return this.patient_priority;
        }

        public int GetPatientCovid19TestResult()
        {
            return this.patient_covid19_testResult;
        }
    }
}
