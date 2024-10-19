using System.Windows.Forms;

namespace Allerts_Mazz
{
    public partial class Form1 : Form
    {
        private int n;
        public Form1()
        {
            InitializeComponent();
            // MessageBox.Show("Costruttore del form", "Debug");
            // non esistono ancora i componenti del form 

            /* inizzializzazione degli attributi del form */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Load");
        }

        private void oneMessage(object obj)
        {
            Parametro arg = (Parametro)obj;
            MessageBox.Show(arg.Numero.ToString(), arg.Caption);
        }
        private void messaggio(object obj)
        {
            Thread[] mes=new Thread[3];
            for (int i = 0; i<3; i++)
            {
                mes[i]= new Thread(oneMessage);
                mes[i].Start(obj);
            
            }

            /*Parametro argomento = obj as Parametro;
            MessageBox.Show(argomento.Numero.ToString(), argomento.Caption);

            MessageBox.Show(((Parametro)obj).Numero.ToString(), ((Parametro)obj).Caption); */
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //avvio unthread che eseguirà la messaggebox show
            //MessageBox.Show("Shown", "DEBUG");
            Parametro uno = new Parametro(1, "ciao");
            Parametro due = new Parametro(2, "miao");

            Thread esecutore1 = new Thread(messaggio);
            esecutore1.Start(uno);
            Thread esecutore2 = new Thread(messaggio);
            esecutore2.Start(due);
            //messaggio();
        }

        
    }
}