using System;
using System.Linq;
using System.Threading;

namespace Vaccination_point_v3_frame.Backstage
{
    static class Threads
    {
        public static void CreateThreads()
        {
            int numberOfPatients = 10;
            for (int i = 0; i < numberOfPatients; i++)
            {
                Thread th = new Thread(Logic.PatientVisit)
                {
                    Name = i.ToString(),
                    IsBackground = true
                };
                th.Start();
            }
        }

        public static void Listbox_tes_actualization()
        {
            while (true)
            {
                mainForm.listbox_tes.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_tes.Items.Clear();
                    if (Vaccination_point.GetTestingBuffer()[0] != null)
                    {
                        for (int i = 0; i < Vaccination_point.GetTestingBuffer().Length; i++)
                        {
                            mainForm.listbox_tes.Items.Add(Vaccination_point.GetTestingBuffer()[0].GetPatientId().ToString());
                            Logic.CounterHandle();
                        }
                    }
                }));
                Thread.Sleep(500);
            }
        }

        public static void Listbox_reg_actualization()
        {
            while(true)
            {
                mainForm.listbox_reg.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_reg.Items.Clear();
                    Patient[] tab = Vaccination_point.GetRegistrationQueue().ToArray();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        mainForm.listbox_reg.Items.Add(tab[i].GetPatientId().ToString());
                        Logic.CounterHandle();
                    }
                }));

               Thread.Sleep(500);
            }
        }

        public static void Listbox_mod_actualization()
        {
            while(true)
            {
                mainForm.listbox_mod.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_mod.Items.Clear();
                    Patient[] tab = Vaccination_point.GetModernaQueue().ToArray();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        mainForm.listbox_mod.Items.Add(tab[i].GetPatientId().ToString());
                        Logic.CounterHandle();
                    }
                }));
                Thread.Sleep(500);

            }
        }

        public static void Listbox_ast_actualization()
        {
            while(true)
            {
                mainForm.listbox_ast.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_ast.Items.Clear();
                    Patient[] tab = Vaccination_point.GetAstraQueue().ToArray();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        mainForm.listbox_ast.Items.Add(tab[i].GetPatientId().ToString());
                        Logic.CounterHandle();
                    }
                }));
                Thread.Sleep(500);

            }
        }

        public static void Listbox_spu_actualization()
        {
            while(true)
            {
                mainForm.listbox_spu.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_spu.Items.Clear();
                    Patient[] tab = Vaccination_point.GetSputnikQueue().ToArray();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        mainForm.listbox_spu.Items.Add(tab[i].GetPatientId().ToString());
                        Logic.CounterHandle();
                    }
                }));
                Thread.Sleep(500);

            }
        }

        public static void Listbox_joh_actualization()
        {
            while(true)
            {
                mainForm.listbox_joh.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_joh.Items.Clear();
                    Patient[] tab = Vaccination_point.GetJJQueue().ToArray();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        mainForm.listbox_joh.Items.Add(tab[i].GetPatientId().ToString());
                        Logic.CounterHandle();
                    }
                }));
                Thread.Sleep(500);

            }
        }

        public static void Listbox_pfi_actualization()
        {
            while(true)
            {
                mainForm.listbox_ast.Invoke(new Action(delegate ()
                {
                    mainForm.listbox_pfi.Items.Clear();
                    Patient[] tab = Vaccination_point.GetPfizerQueue().ToArray();
                    for (int i = 0; i < tab.Length; i++)
                    {
                        mainForm.listbox_pfi.Items.Add(tab[i].GetPatientId().ToString());
                        Logic.CounterHandle();
                    }
                }));
                Thread.Sleep(500);
            }
        }
    }
}
