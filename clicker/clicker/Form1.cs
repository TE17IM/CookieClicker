using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Detta är för att inkludera alla StreamReader och StreamWriter saker. Används för att "spara" och "ladda".
// för System.IO är det mer sant att det används för att läsa av och skriva ned saker i ett dokument. Inte bara .txt då.

namespace clicker // Namnet på projektet.
{
    public partial class Form1 : Form // Vad är det för slags projekt? I detta fall Form.
    {
        Timer timer = new Timer(); // Gör timern till en allmän timer.
        Timer timer2 = new Timer(); // Timer för att rensa skriv fältet för att få kakor uppgraderingen.
        Timer challenge = new Timer(); // Timer för challenge.
        int xy = 2000; // Kak tid
        
        public Form1() // Vid start händer nedan.
        {
           
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick); //Allt som variabeln timer gör ska hända i en void med detta namn.
            timer.Interval = (1000); // Varje 1000 milisekund, alltså varje sekund.
            timer.Enabled = true; // När programmet startar aktiveras timern.
            timer.Start(); // Timern startar då programmet startar.
            pictureBox1.Load("http://www.pngall.com/wp-content/uploads/2016/07/Cookie-PNG-Clipart-180x180.png");
            timer2.Tick += new EventHandler(Cookie_Tick);
            timer2.Interval = (xy);
            timer2.Enabled = true;
            timer2.Start();
           // challenge.Tick += new EventHandler(Challenge_Tick);
            challenge.Interval = (100);
            challenge.Enabled = true;
            challenge.Start();
            this.textBox2.KeyPress += new KeyPressEventHandler(TextBox2_KeyPress);
        }
        public bool challengeon = false; //Ser om en challenge ska sättas igång.
       /* void Challenge_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 100) // Är det inte 100%...
            {
                progressBar1.Value += 1; // +1%
            }
            else if(progressBar1.Value == 100) // Är den 100%...
            {
                challengeon = true; // challenge sätts igång.
            }
            else if(challengeon == true) // Är challenge igång...
            {
                progressBar1.Value -= 1; // -1%, som en timer.
            }
            else if(challengeon == true && progressBar1.Value <= 0) // Är challenge på och den är 0%...
            {
                challengeon = false; // Challenge av.
            }
        }*/

        void Cookie_Tick(object sender, EventArgs e) // För att skriva för kakor
        {
            textBox2.Clear();
        }
        
         void Timer_Tick(object sender, EventArgs e) // Varje sekund händer allting här inne.
        {
            int kakaisek = xx + kaka3; // Kaka i sekunden under antalet kakor i programmet (ovanför klicka knappen).
            antKakor += xx + kaka3; // Räknar antalet kakor så att antalet uppdaterar varje sekund. Viktigt för att se när man får mer kakor av +1kaka/sek.
            label1.Text = "Kakor = " + antKakor; //Enkel kod för att uppdatera texten med antalet kakor.
            label3.Text = "Kakor i sekunden = " + kakaisek;
            label2.Text = cks + "st.";
            label4.Text = xx + "st.";
            label5.Text = (kaka3/2) + "st.";
            button5.Text = "[" + kakasek3 + "]" + " +2 kaka/s"; //Samma kod fast med knapp texten.
            button2.Text = "[" + kakasek + "]" + " +1 Kaka / klick";
            button3.Text = "[" + kakasek2 + "]" + " +1 kaka/s";
            if (bought == false)
            {
                label8.Text = "Köpt: " + bought;
            }
            else if(bought == true)
            {
                label8.Text = yx + "st.";
            }
            label10.Text = button7st + "st.";
        }

        private void Form1_Load(object sender, EventArgs e) //När programmet laddas, används inte just nu.
        {
            // Används inte.
        }

        private void Label1_Click(object sender, EventArgs e) //När man klickar på texten1, används inte just nu.
        {
            // Anvädns inte.
        }

        public double antKakor = 0; // Två olika variabler för att hålla koll på antalet kakor.
        public int xx = 0; // Denna för att räkna ihop med annan kod antalet kakor i sekunden.
        

        public void Form1_KeyPress(object sender, KeyEventArgs click) //Om man klickar en tangent i Windows Form. Används inte just nu.
        {
            
        }

        public int cks = 0; // Räknar hur många gånger man köpt uppgraderingen "+1 kaka / klick".
        public int kakasek = 100; // Priset för uppgraderingen "+1 kaka / klick".

        private void Button2_Click(object sender, EventArgs e) // Knappen för att köpa +1 kaka / klick uppgraderingen.
        {
            if(antKakor>=kakasek) //Om antalet kakor man har är mer eller likamed priset, händer:
            {
                cks++;
                antKakor -= kakasek; //Minskar ens kakor med priset av uppgraderingen.
                label2.Text = cks + "st."; //Uppdaterar texten bredvid köp knappen.
                kakasek *= 2; // Ökar priset av denna uppgraderingen med 2.
                button2.Text = "[" + kakasek + "]" + " +1 Kaka / klick"; //Uppdaterar texten på knappen så att priset i [] stämmer.
             
            }
            else // om man inte har råd...
            {
                MessageBox.Show("Du har inte råd!"); //Text ruta kommer fram som visar texten inom paranteserna.
            }
        }

        private void Label2_Click(object sender, EventArgs e) // Om man klickar texten, används inte just nu.
        {
           // Används inte.
        }

        private void Label3_Click(object sender, EventArgs e) // Om man klickar texten, används inte just nu.
        {
            // Används inte.
        }


        public int kakasek2 = 100; // Start priset för +1kaka / sekunden uppgraderingen.
        private void Button3_Click(object sender, EventArgs e)
        {
            if(antKakor>=kakasek2) // Om man har råd (Om antalet kakor man har är större eller lika med priset, händer..:)
            {
                xx++; // Texten bredvid knappen för att köpa uppgraderingen "+1 kaka / sekunden" ändras till antalet gånger man köpt den.
                antKakor -= kakasek2; // Minskar ens pengar / kakor med priset för uppgraderingen.
                label4.Text = xx + "st."; // Två rader upp är det denna som visar texten, xx++ gör så att den blir till +1 varje gång man köper denna.
                kakasek2 += kakasek2 / 2; // Ökar priset med 50% av priset varje gång. Är priset 100  blir det 100 + 100/2, så 150. Sedan blir det 150 + 150/2 som är 225. osv..
                button3.Text = "[" + kakasek2 + "]" + " +1 kaka/s"; // Texten uppdaterar på knappen enligt priset.
            }
            else // Har man inte råd händer...
            {
                MessageBox.Show("Du har inte råd!"); // Text ruta kommer fram med texten inuti paranteserna.
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) // Rutan man skriver sitt namn.
        {
            // Ingenting händer här.
        }

        public void Button4_Click(object sender, EventArgs e) // Där man klickar "Spara" för att spara.
        {
            SaveFileDialog sf = new SaveFileDialog(); // Gör en enkel variabel för SaveFileDialog.
            // SaveFileDialog är rutan som kommer fram då man t.ex klickar på "Spara som..." knappen på nätet. 
            // Man får välja vart filen ska sparas och även namnet på filen!
            sf.Filter = "txt files (*.txt)|*.txt"; // Detta ser till att man kan bara spara filen som en .txt fil.
            sf.FilterIndex = 2; // Väljer den andra *.något saken. I detta fall *.txt, alltså .txt fil.
            sf.RestoreDirectory = true; // Öppnar i "default" stället, i detta fall i själva mappen som alla visual studio project filer finns.
            if(sf.ShowDialog() == DialogResult.OK && textBox1.TextLength != 0 && textBox3.TextLength != 0) //Om stället man valde att spara är korrekt och fungerar, händer...
            {
                using (StreamWriter spara = new StreamWriter(sf.FileName)) //Detta är för att spara alla värden i spelet med samma namn som man angav ovan.
                {

                    spara.WriteLine(textBox1.Text); // Första raden. [0] i Arrays.
                    spara.WriteLine(xx); // Andra raden. [1] i en Array. Du fattar längre ned när man Laddar en Spar fil.
                    spara.WriteLine(antKakor);
                    spara.WriteLine(kakasek);
                    spara.WriteLine(kakasek2);
                    spara.WriteLine(kakasek3);
                    spara.WriteLine(cks);
                    spara.WriteLine(kaka3);
                    spara.WriteLine(textBox3.Text); //lösenordet.
                    spara.Close(); // Se till att den stängs och att allting "sparas" fullständigt.
                    MessageBox.Show("Sparat!");
                }
            }
            else if(textBox1.TextLength <= 0 && textBox3.TextLength <= 0)
            {
                MessageBox.Show("Du måste ha ett namn och lösenord!");
            }
           
        }
        
        

        
        
        public int kakasek3 = 200; // Variabel för priset på uppgraderingen "+2 kaka / sekunden".
        public int kaka3 = 0; // Hur många gånger man köpt den.
        private void Button5_Click(object sender, EventArgs e) // Knappen för uppgraderingen "+2 kaka / sekunden".
        {
            if(antKakor>=kakasek3) // Om man har råd...
            {
                antKakor -= kakasek3; // Minskar antalet kakor man har med priset.

                kakasek3 += kakasek3 / 2; // Ökar priset med 50% av priset. 100 blir då 150, som sedan blir 225, osv.
                kaka3 += 2; // Integer uppdateras med 2, den adderas med 2.
                label5.Text = (kaka3/2) + "st."; // Texten bredvid knappen visar hur många gånger man köpt den.
                // Den halveras alltid för den adderas med +2 som ovan. Köper man den en gång visar den 2, så man halverar den.
                button5.Text = "[" + kakasek3 + "]" + " +2 kaka/s"; // Uppdaterar priset på uppgraderings knappen.
            }
        }

        public void Button6_Click(object sender, EventArgs e) // "Ladda" knappen längst ned till höger.
        {
            OpenFileDialog df = new OpenFileDialog(); // Samma som SaveFileDialog fast man "öppnar" filen istället.
            df.Filter = "txt files (*.txt)|*.txt"; // Ser till att man kan bara öppna / se .txt filer.
            df.FilterIndex = 2; // Det blir *.txt och inte (*.txt). 
            // Detta är för att (*.txt) ska "visa" vilka filer som syns. I detta fall SKA bara .txt väljas, så *.txt väljs då.
            // Hade platserna varit bytta, alltså *.txt|(*.txt) skulle det vara FilterIndex = 1;
            df.RestoreDirectory = true; // Så att när man öppnar en mapp så är det "default".
            if (df.ShowDialog() == DialogResult.OK) // Om allting ovan är korrekt...
            {
                string[] lines = File.ReadAllLines(df.FileName); //Läser alla rader i txt filen.
                if (textBox3.Text == lines[8]) //stämmer lösenord lådan med lösenordet i filen, eller om filen inte har lösenord...
                {
                    MessageBox.Show("Välkommen tillbaka " + lines[0] + "!"); //Första raden i filen. [0] är raden längst upp.
                    xx = Convert.ToInt32(lines[1]); // Andra raden i filen.
                    // xx är en Int fil, ReadAllLines är String default. Måste konverteras!
                    // Detta behövs för alla Int variabler.
                    antKakor = Convert.ToInt32(lines[2]); // Du fattar.
                    kakasek = Convert.ToInt32(lines[3]);
                    kakasek2 = Convert.ToInt32(lines[4]);
                    kakasek3 = Convert.ToInt32(lines[5]);
                    cks = Convert.ToInt32(lines[6]);
                    kaka3 = Convert.ToInt32(lines[7]);
                }
                else // har filen lösenord och man skrivit fel lösenord...
                {
                    MessageBox.Show("Fel lösenord!");
                }
            }
        }

        public void PictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = ("Kakor = " + antKakor); //Uppdaterar texten varje gång man klickar knappen.
            antKakor += 1 + cks; //Lägger till 1 + extra kakorna om man har mer kakor / klick uppgraderingar.
        }
        int yx = 3; // hur många bokstäver man kan skriva i lådan.
        
        private void TextBox2_TextChanged(object sender, EventArgs e) //Lådan man skriver i.
        {
            textBox2.MaxLength = yx; //Max antal bokstäver i lådan.
            if (bought == true) // Om man köpt uppgraderingen...
            {
                label1.Text = ("Kakor = " + antKakor); //Uppdaterar texten när man skriver.
                antKakor += 1; //Lägger till kakor.
                label8.Text = yx + "st.";
                
            }
            else if(bought == false) // Har man inte köpt den...
            {
                MessageBox.Show("Du har inte köpt uppgraderingen!");
            }
           
            
            
         
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Back)
            {
                MessageBox.Show("Inte tillåtet!");
                e.Handled = true;
            }
        }
        bool bought = false; // Default falskt.
        private void Button1_Click(object sender, EventArgs e) // Köp knappen "skriv för +1 kaka".
        {
            int price = 250; // Sätter priset.
            if (antKakor >= price && bought == false) // Har man råd och inte köpt...
            {
                antKakor -= price;
                bought = true;
                label8.Text = "Köpt: " + bought;
            }
            else if (antKakor != price) // Har man inte råd...
            {
                MessageBox.Show("Du har inte råd!");
            }
            else if (bought == true) // Har man redan köpt...
            {
                MessageBox.Show("Du har redan köpt den!");
            }

        }
        int button7st = 0;
        int button7pris = 100;
        private void Button7_Click(object sender, EventArgs e) // +1 skriv knappen.
        {
            if (button7st <= 7 && antKakor>=button7pris) // har man 7 eller mindre köpt på denna och har råd...
            {
                antKakor -= button7pris;
                button7pris += button7pris / 2;
                label10.Text = button7st + "st."; //Uppdaterar texten enligt antalet gånger man köpt den.
                button7st++;
                yx++;
            }
            else // annars...
            {
                MessageBox.Show("Du har inte råd / Du har max uppgraderat! (7st)");
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text == "kakpower")
            {
                antKakor += 1000;
                textBox4.Clear();
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            //Anänds inte just nu...
        }
    }
}
