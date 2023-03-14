using System;
using System.Threading;
using System.Windows.Forms;
using Vaccination_point_v3_frame.Backstage;

namespace Vaccination_point_v3_frame
{
    public partial class mainForm : Form
    {
        //deklaracje zmiennych do obsługi elementów w oknie wymagających odświeżania
        public static ListBox listbox_reg,
            listbox_tes, listbox_pfi,
            listbox_mod, listbox_ast,
            listbox_spu, listbox_joh;
            
        public static Label vaccinated_counter, 
            positive_counter, modernaVaccinated_counter,
            astraVaccinated_counter, sputnikVaccinated_counter,
            jjVaccinated_counter, pfizerVaccinated_counter;
        
        public mainForm()
        {
            InitializeComponent();
        }
        
        //pokurwonstruktor
        private void Vaccination_point_Load(object sender, EventArgs e)
        {
            listbox_reg = listbox_registration;
            listbox_tes = listbox_covidTested;
            listbox_mod = listbox_moderna;
            listbox_ast = listbox_astraZeneca;
            listbox_spu = listbox_sputnik;
            listbox_joh = listbox_jj;
            listbox_pfi = listbox_pfizer;

            vaccinated_counter = number_of_vaccinated_people;
            positive_counter = number_of_covidPositive_people;
            modernaVaccinated_counter = moderna_vaccinated;
            astraVaccinated_counter = astraZeneca_vaccinated;
            sputnikVaccinated_counter = sputnik_vaccinated;
            jjVaccinated_counter = jj_vaccinated;
            pfizerVaccinated_counter = pfizer_vaccinated;

            Thread listbox_reg_act = new Thread(Threads.Listbox_reg_actualization)
            {
                IsBackground = true
            };
            listbox_reg_act.Start();

            Thread listbox_tes_act = new Thread(Threads.Listbox_tes_actualization)
            {
                IsBackground = true
            };
            listbox_tes_act.Start();

            Thread listbox_mod_act = new Thread(Threads.Listbox_mod_actualization)
            {
                IsBackground = true
            };
            listbox_mod_act.Start();

            Thread listbox_ast_act = new Thread(Threads.Listbox_ast_actualization)
            {
                IsBackground = true
            };
            listbox_ast_act.Start();

            Thread listbox_spu_act = new Thread(Threads.Listbox_spu_actualization)
            {
                IsBackground = true
            };
            listbox_spu_act.Start();

            Thread listbox_joh_act = new Thread(Threads.Listbox_joh_actualization)
            {
                IsBackground = true
            };
            listbox_joh_act.Start();

            Thread listbox_pfi_act = new Thread(Threads.Listbox_pfi_actualization)
            {
                IsBackground = true
            };
            listbox_pfi_act.Start();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Threads.CreateThreads();
        }
    }
}
