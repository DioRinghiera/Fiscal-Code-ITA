using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CodiceFiscale
{
    public partial class Form1 : Form
    {
        // stringhe per conversione
        string mesi = "ABCDEHLMPRST";
        string codiceControllo = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        // var. per testo delle TextBox
        string Cognome, Nomee, sesso;
        string day, month, year;
        string Comune, provincia;

        // var. per codice catastale
        bool isOk = true;
        Array citta_arr;
        List<string> citta;
        List<string> cod;

        // var. per salvare nel file .txt
        string pathCSV = Environment.CurrentDirectory + @"\CodiceCatastale.csv";
        string name = "", surname = "", city = "";
        string days = "", months = "", years = "";
        string sex = "", provinc = "", registro = "";

        public Form1()
        {
            InitializeComponent();
            cog.CharacterCasing = CharacterCasing.Upper;
            nome.CharacterCasing = CharacterCasing.Upper;
            comunee.CharacterCasing = CharacterCasing.Upper;
            provinciaa.CharacterCasing = CharacterCasing.Upper;
        }

        // Cognome
        private void cog_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premute solo lettere
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }

        // Nome
        private void nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premute solo lettere
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }


        // Maschio
        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked) female.Checked = false;
            else female.Checked = true;
        }

        // Femmina
        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (female.Checked) male.Checked = false;
            else male.Checked = true;
        }


        // Comune
        private void comunee_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premute solo lettere
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }

        // Provincia
        private void provinciaa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premute solo lettere
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }



        // Giorno
        private void giorno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premuti solo numeri
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }

        // Mese
        private void mese_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premuti solo numeri
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }

        // Anno
        private void anno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // vengono premuti solo numeri
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)) && (!char.IsControl(e.KeyChar))) e.Handled = true;
        }

        // Calcola
        private void calc_Click(object sender, EventArgs e)
        {
            // ottieni testi dalle TextBox
            Cognome = cog.Text.Trim();
            Nomee = nome.Text.Trim();
            if (male.Checked) sesso = "M";
            else sesso = "F";
            day = giorno.Text.Trim();
            month = mese.Text.Trim();
            year = anno.Text.Trim();
            Comune = comunee.Text.Trim();
            provincia = provinciaa.Text.Trim();

            // se tutti i campi non sono vuoti
            if (Cognome != "" && Nomee != "" && day != "" && month != "" && year != "" && Comune != "" && provincia != "")
            {
                isOk = get(); // <-- ottiene codice catastale delle provincie
                if (isOk) LabelCodice.Text = calcola();
                else
                {
                    msgBox("Error", "File citta .csv non trovato!", MessageBoxButtons.OK, MessageBoxIcon.Error); // <-- se errore nell'ottenere codice cat.

                    openFileDialog1.Title = "Specifica il file .csv delle citta'";
                    openFileDialog1.Filter = "CSV File | *.csv";
                    openFileDialog1.FileName = "CodiceCatastale";
                    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

                    if (result == DialogResult.OK) pathCSV = Path.GetDirectoryName(openFileDialog1.FileName) + @"\" + openFileDialog1.FileName;
                }
            }
            else msgBox("Empty", "Devi completare correttamente tutti i campi!", MessageBoxButtons.OK, MessageBoxIcon.Error); // <-- se alcuni campi sono vuoti
        }


        // --------- MENU ---------
        // Salva
        private void salvaMenu_Click(object sender, EventArgs e)
        {
            string date = days + "/" + months + "/" + years;

            // crea testo da scrivere nel file personalizzato
            string[] text = { "--------------------------", "DATI:", "Nome: " + name, "Cognome: " + surname, "Comune: " + city,
                              "Data di nascita: " + date, "Sesso: " + sex, "Provincia: " + provinc, "Codice: " + registro,
                              "Data: " + DateTime.Today.ToString("dd/MM/yyyy") + " - " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(),
                              "--------------------------"};

            if (registro.Length != 0)
            {
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog1.FileName = name + "_" + surname + ".txt";
                saveFileDialog1.Filter = "Text File | *.txt";

                DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                {
                    // salva testo personalizzato nel file .txt
                    StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                    foreach (string str in text)
                        writer.WriteLine(str);
                    
                    writer.Dispose();
                    writer.Close();
                    msgBox("Saved!", "File .txt salvato in " + Path.GetDirectoryName(saveFileDialog1.FileName), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else msgBox("Warning!", "Devi prima calcolare almeno 1 codice fiscale", MessageBoxButtons.OK, MessageBoxIcon.Warning); // <-- se non è stato calcolato alcun codice
        }

        // azzera textbox e radiobutton
        private void clear_Click(object sender, EventArgs e)
        {
            cog.Text = "";
            nome.Text = "";
            comunee.Text = "";
            provinciaa.Text = "";
            giorno.Text = "1";
            mese.Text = "1";
            anno.Text = "1970";
            male.Checked = true;
            female.Checked = false;
            codiLabel.Visible = false;
            LabelCodice.Text = "";
            LabelCodice.Visible = false;
        }

        // Random
        private void random_Click(object sender, EventArgs e)
        {
            if (get()) randomize();
            else
            {
                msgBox("Error", "File citta .csv non trovato!", MessageBoxButtons.OK, MessageBoxIcon.Error); // <-- se errore nell'ottenere codice cat.

                openFileDialog1.Title = "Specifica il file .csv delle citta'";
                openFileDialog1.Filter = "CSV File | *.csv";
                openFileDialog1.FileName = "CodiceCatastale.csv";
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

                if (result == DialogResult.OK) pathCSV = openFileDialog1.FileName;
                Console.WriteLine(pathCSV);
            }
        }

        private void randomize()
        {
            Random rand = new Random();
            int index = rand.Next(0, 8);

            // Stringhe esempi
            string[] nomi = { "TOMMASO", "ANDREA", "FILIPPO", "GIOVANNI", "CHIARA", "BIANCA", "ASIA", "ELISABETTA" };
            string[] cognomi = { "ROSSI", "VERDI", "BIANCHI", "NARDON", "SARTORI", "FERRARI", "COSTA", "FONTANA" };
            string[] ses = { "M", "M", "M", "M", "F", "F", "F", "F" };
            string[] comuni = { "VICENZA", "ROMA", "NAPOLI", "MILANO", "VERONA", "FIRENZE", "PALERMO", "RAGUSA" };
            string[] provinciaa_ = { "VI", "RM", "NP", "MI", "VR", "FI", "PA", "RG" };

            // Estrai giorno, mese, anno
            int giorno_ = rand.Next(1, 29);
            int mese_ = rand.Next(1, 13);
            int anno_ = rand.Next(1900, 2021);

            // Assegna stringhe 
            Nomee = nomi[index];
            Cognome = cognomi[index];
            sesso = ses[index];
            day = giorno_.ToString();
            month = mese_.ToString();
            year = anno_.ToString();
            Comune = comuni[index];
            provincia = provinciaa_[index];

            // Imposta testi textboxs
            cog.Text = Cognome;
            nome.Text = Nomee;
            comunee.Text = Comune;
            provinciaa.Text = provincia;
            giorno.Text = day;
            mese.Text = month;
            anno.Text = year;
            if (sesso == "M") male.Checked = true;
            else female.Checked = true;
            
            // Calcola
            LabelCodice.Text = calcola();
        }

        // Esci
        private void esciMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // About -> ?
        private void puntodomMenu_Click(object sender, EventArgs e)
        {
            msgBox("App per codice fiscale", "Data: 31/12/2020\nCreatore: TiSi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // copia codice negli appunti
        private void LabelCodice_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LabelCodice.Text);
            msgBox("Copied!", "Codice copiato negli appunti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // mostra messagebox
        private void msgBox(string title, string text, MessageBoxButtons button, MessageBoxIcon icon)
        {
            MessageBox.Show(text, title, button, icon);
        }

        // ottieni codice catastale e città
        private bool get()
        {
            try
            {
                using (var reader = new StreamReader(pathCSV))
                {
                    // 2 colonne
                    citta = new List<string>();
                    cod = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        // aggiungi valori
                        citta.Add(values[0].ToUpper());
                        cod.Add(values[1]);
                    }
                }
                // trasforma citta in array
                citta_arr = citta.ToArray();
                return true; // <-- tutto a posto
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false; // <-- errore
            }
        }

        // script per codice fiscale
        private string calcola()
        {
            bool citt = false;

            // rendi textbox visibili
            LabelCodice.Visible = true;
            codiLabel.Visible = true;

            // var. per calcolo del codice
            string codice = "";
            string vocali = "", consonanti = "";
            string anno34 = year[year.Length - 2].ToString() + year[year.Length - 1].ToString(); // ultime 2 cifre dell'anno

            // variabili per salvare eventualmente nel file .txt successivamente
            name = Nomee;
            surname = Cognome;
            days = day;
            months = month;
            years = year;
            city = Comune;
            provinc = provincia;
            sex = sesso;

            // rimuovo eventuali spazi
            for (int i = 0; i < Cognome.Length; i++)
                if (Cognome[i].ToString() == " ") Cognome = Cognome.Remove(i, 1);

            // adatto eventuali vocali accentate
            Cognome = Cognome.Replace("à".ToUpper(), "A");
            Cognome = Cognome.Replace("è".ToUpper(), "E");
            Cognome = Cognome.Replace("é".ToUpper(), "E");
            Cognome = Cognome.Replace("ì".ToUpper(), "I");
            Cognome = Cognome.Replace("ò".ToUpper(), "O");
            Cognome = Cognome.Replace("ù".ToUpper(), "U");

            // estraggo vocali cognome
            for (int i = 0; i < Cognome.Length; i++)
            {
                if (Cognome[i] == 'A' || Cognome[i] == 'E' || Cognome[i] == 'I' || Cognome[i] == 'O' || Cognome[i] == 'U' && Cognome[i] != ' ')
                    vocali += Cognome[i].ToString(); // aggiungo a vocali
            }

            // estraggo consonanti cognome
            for (int i = 0; i < Cognome.Length; i++)
            {
                if (Cognome[i] != 'A' && Cognome[i] != 'E' && Cognome[i] != 'I' && Cognome[i] != 'O' && Cognome[i] != 'U' && Cognome[i] != ' ')
                    consonanti += Cognome[i].ToString(); // aggiungo a consonanti
            }

            string tmp = consonanti + vocali;

            if (tmp.Length < 3)
            {
                codice += tmp + "X"; // aggiungo X
            }
            else
            {
                codice += tmp[0]; // aggiungo la 1' lettera
                codice += tmp[1]; // la 2'
                codice += tmp[2]; // la 3'
            }

            // azzero stringhe
            consonanti = "";
            vocali = "";

            // estraggo vocali nome
            for (int i = 0; i < Nomee.Length; i++)
            {
                if (Nomee[i] == 'A' || Nomee[i] == 'E' || Nomee[i] == 'I' || Nomee[i] == 'O' || Nomee[i] == 'U' && Nomee[i] != ' ')
                    vocali += Nomee[i].ToString(); // aggiungo a vocali
            }

            // estraggo consonanti nome
            for (int i = 0; i < Nomee.Length; i++)
            {
                if (Nomee[i] != 'A' && Nomee[i] != 'E' && Nomee[i] != 'I' && Nomee[i] != 'O' && Nomee[i] != 'U' && Nomee[i] != ' ')
                    consonanti += Nomee[i].ToString(); // aggiungo a consonanti
            }

            tmp = consonanti + vocali;

            if (consonanti.Length > 3)
            {
                codice += tmp[0]; // aggiungo la 1' lettera
                codice += tmp[2]; // la 3'
                codice += tmp[3]; // la 4'
            }
            else if (tmp.Length < 3)
            {
                codice += tmp + "X"; // aggiungo X
            }
            else
            {
                codice += tmp[0]; // aggiungo la 1' lettera
                codice += tmp[1]; // la 2'
                codice += tmp[2]; // la 3'
            }

            // aggiungo ultime 2 cifre dell'anno
            codice += anno34;

            // aggiungo lettera che corrisponde al mese
            codice += mesi[Convert.ToInt32(month) - 1];

            // aggiungo giorno in base al sesso
            if (sesso.ToUpper() == "M")
                codice += day;

            else if (sesso.ToUpper() == "F")
                codice += Convert.ToInt32(day) + 40; // aggiungo +40 perché femmina

            // aggiungo codice del comune
            try
            {
                codice += cod[Array.IndexOf(citta_arr, Comune.ToUpper())].ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                msgBox("Error", "La città inserita non è valida\nAssicurati di aver inserito il nome corretto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                citt = true;
            }

            // Codice Di Controllo
            int sum = 0;

            // conversione in numeri dei caratteri in posizione pari
            for (int i = 1; i < codice.Length; i += 2)
            {
                // se convertibile in numero
                if (int.TryParse(codice[i].ToString(), out int value)) sum += value;
                else sum += Convert.ToInt32(codice[i]) - 65; // 65 = numero di posizione della 1' lettera nel codice ASCII
            }

            // conversione in numeri dei caratteri in posizione dispari
            for (int i = 0; i < codice.Length; i += 2)
            {
                switch (codice[i].ToString())
                {
                    case "A":
                    case "0":
                        sum += 1;
                        break;

                    case "C":
                    case "2":
                        sum += 5;
                        break;

                    case "D":
                    case "3":
                        sum += 7;
                        break;

                    case "E":
                    case "4":
                        sum += 9;
                        break;

                    case "F":
                    case "5":
                        sum += 13;
                        break;

                    case "G":
                    case "6":
                        sum += 15;
                        break;

                    case "H":
                    case "7":
                        sum += 17;
                        break;

                    case "I":
                    case "8":
                        sum += 19;
                        break;

                    case "J":
                    case "9":
                        sum += 21;
                        break;

                    case "K":
                        sum += 2;
                        break;

                    case "L":
                        sum += 4;
                        break;

                    case "M":
                        sum += 18;
                        break;

                    case "N":
                        sum += 20;
                        break;

                    case "O":
                        sum += 11;
                        break;

                    case "P":
                        sum += 3;
                        break;

                    case "Q":
                        sum += 6;
                        break;

                    case "R":
                        sum += 8;
                        break;

                    case "S":
                        sum += 12;
                        break;

                    case "T":
                        sum += 14;
                        break;

                    case "U":
                        sum += 16;
                        break;

                    case "V":
                        sum += 10;
                        break;

                    case "W":
                        sum += 22;
                        break;

                    case "X":
                        sum += 25;
                        break;

                    case "Y":
                        sum += 24;
                        break;

                    case "Z":
                        sum += 23;
                        break;

                }
            }

            // calcolo resto
            int resto = sum % 26;

            // Converto resto in lettera
            codice += codiceControllo[resto].ToString();

            if (citt == false)
            {
                registro = codice; // <-- salva codice nel registro
                return codice;
            }
            else
            {
                registro = "";
                return "";
            }
        }
    }
}
