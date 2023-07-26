using System;
using System.Threading;

namespace Vaccination_point_v3_frame.Backstage
{
     static class Logic
     { 
        /* Values of preferedPreparation enum:
         * 1. - Moderna
         * 2. - AstraZeneca
         * 3. - Sputnik
         * 4. - Johnson & Johnson
         * 5. - Pfizer
         */

        public static void PatientVisit()
        {
            int prep = (new Random()).Next(6);
            Thread.Sleep(150);
            int patientsPriority = (new Random()).Next(2);
            Patient pat = new Patient(("patient_" + Thread.CurrentThread.Name), prep, patientsPriority);
            Vaccination_point.AddPatientToRegistrationQueue(pat);
            Vaccination_point.AddPatientToTestingBuffer();
            TestPatient();
            Thread.Sleep(500);
            if (pat.GetPatientCovid19TestResult() == 1)
            {
                Monitor.Exit(Vaccination_point.testing_box);
                return;
            }
            else
            {
                Thread.Sleep(2000);
                Vaccination_point.AddPatientToVaccinationQueue();
            }

        }

        private static int GetTestResult()
        {
            int result = ((new Random()).Next(500) % 2);
            Thread.Sleep(150);
            return result;
        }


        public static void TestPatient()
        {
            Patient tested_patient = Vaccination_point.GetTestingBuffer()[0];

            int result = GetTestResult();
            if(result == 1)
            {
                tested_patient.SetPatientCovid19TestResult(1);
                Vaccination_point.testPositive_counter++;
            }
            else
            {
                tested_patient.SetPatientCovid19TestResult(0);
                Vaccination_point.testNegative_counter++;
            }
        }

        public static void CounterHandle()
        {
            mainForm.vaccinated_counter.Text = (Vaccination_point.moderna_vacCounter+Vaccination_point.pfizer_vacCounter+
            Vaccination_point.sputnik_vacCounter+Vaccination_point.jj_vacCounter+Vaccination_point.astra_vacCounter).ToString();

            mainForm.positive_counter.Text = (Vaccination_point.testPositive_counter).ToString();

            mainForm.modernaVaccinated_counter.Text = (Vaccination_point.moderna_vacCounter).ToString();
            mainForm.astraVaccinated_counter.Text = (Vaccination_point.astra_vacCounter).ToString();
            mainForm.sputnikVaccinated_counter.Text = (Vaccination_point.sputnik_vacCounter).ToString();
            mainForm.jjVaccinated_counter.Text = (Vaccination_point.jj_vacCounter).ToString();
            mainForm.pfizerVaccinated_counter.Text = (Vaccination_point.pfizer_vacCounter).ToString();
        }
     }      
}       
        