using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Vaccination_point_v3_frame.Backstage
{
    static class Vaccination_point
    {
        //kolejka do rejestracji i bufor dla pacjenta na teście
        public static LinkedList<Patient> registration_queue;
        public static Patient[] testing_buffer;

        //kolejki do gabinetu
        public static LinkedList<Patient> moderna_queue;
        public static LinkedList<Patient> astra_queue;
        public static LinkedList<Patient> sputnik_queue;
        public static LinkedList<Patient> jj_queue;
        public static LinkedList<Patient> pfizer_queue;

        //monitor
        public static object registration_que = new object();
        public static object testing_box = new object();

        public static Semaphore semFirst = new Semaphore(0,1);

        //zmienna do counterów
        public static int testNegative_counter = 0,
            testPositive_counter = 0, moderna_vacCounter = 0,
            astra_vacCounter = 0, sputnik_vacCounter = 0,
            jj_vacCounter = 0, pfizer_vacCounter = 0;


        static Vaccination_point()
        {
            registration_queue = new LinkedList<Patient>();
            moderna_queue = new LinkedList<Patient>();
            astra_queue = new LinkedList<Patient>();
            sputnik_queue = new LinkedList<Patient>();
            pfizer_queue = new LinkedList<Patient>();
            jj_queue = new LinkedList<Patient>();

            testing_buffer = new Patient[1];
        }

        public static void AddPatientToRegistrationQueue(Patient pat)
        {
            //w zależności od priorytetu pacjent dodawany jest na koniec lub początek kolejki
            Monitor.Enter(registration_que);
            if(pat.GetPatientPriority() == 1)
            {
                registration_queue.AddFirst(pat);
            }
            else if(pat.GetPatientPriority() == 0)
            {
                registration_queue.AddLast(pat);
            }
            Monitor.Exit(registration_que);
        }

        public static void AddPatientToTestingBuffer()
        {
            Monitor.Enter(testing_box);
            try
            {
                testing_buffer[0] = registration_queue.First();
                registration_queue.RemoveFirst();
            }
            catch
            {

            }

        }

        public static void AddPatientToVaccinationQueue()
        {
            switch(testing_buffer[0].GetPreferedPreparation())
            {
                case PreparationType.MODERNA:

                    if(testing_buffer[0].GetPatientPriority() == 1)
                    {
                        moderna_queue.AddFirst(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    else
                    {
                        moderna_queue.AddLast(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    moderna_vacCounter++;
                    Thread.Sleep(3000);
                    moderna_queue.RemoveFirst();
   
                    break;
                case PreparationType.ASTRAZENECA:
                    
                    if (testing_buffer[0].GetPatientPriority() == 1)
                    {
                        astra_queue.AddFirst(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    else
                    {
                        astra_queue.AddLast(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    astra_vacCounter++;
                    Thread.Sleep(3000);
                    astra_queue.RemoveFirst();

                    break;
                case PreparationType.SPUTNIK:

                    if (testing_buffer[0].GetPatientPriority() == 1)
                    {
                        sputnik_queue.AddFirst(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    else
                    {
                        sputnik_queue.AddLast(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    sputnik_vacCounter++;
                    Thread.Sleep(3000);
                    sputnik_queue.RemoveFirst();

                    break;
                case PreparationType.JJ:

                    if (testing_buffer[0].GetPatientPriority() == 1)
                    {
                        jj_queue.AddFirst(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    else
                    {
                        jj_queue.AddLast(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    jj_vacCounter++;
                    Thread.Sleep(3000);
                    jj_queue.RemoveFirst();

                    break;
                case PreparationType.PFIZER:

                    if (testing_buffer[0].GetPatientPriority() == 1)
                    {
                        pfizer_queue.AddFirst(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    else
                    {
                        pfizer_queue.AddLast(testing_buffer[0]);
                        testing_buffer[0] = null;
                    }
                    pfizer_vacCounter++;
                    Thread.Sleep(3000);
                    pfizer_queue.RemoveFirst();

                    break;
            }
            Monitor.Exit(testing_box);
        }

        public static Patient[] GetTestingBuffer()
        {
            return testing_buffer;
        }

        public static LinkedList<Patient> GetRegistrationQueue()
        {
            return registration_queue;
        }

        public static LinkedList<Patient> GetModernaQueue()
        {
            return moderna_queue;
        }

        public static LinkedList<Patient> GetAstraQueue()
        {
            return astra_queue;
        }

        public static LinkedList<Patient> GetSputnikQueue()
        {
            return sputnik_queue;
        }

        public static LinkedList<Patient> GetJJQueue()
        {
            return jj_queue;
        }

        public static LinkedList<Patient> GetPfizerQueue()
        {
            return pfizer_queue;
        }
    }
}
