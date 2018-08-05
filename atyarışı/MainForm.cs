/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: abuzer
 * Tarih: 25.7.2018
 * Zaman: 20:44
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atyarışı
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public int zaman=0;
		public int atılma=0;
		public int zaman1=0;
		public int atılma1=0;
		void MainFormLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
		public void kos()
		{
			if(zaman<100 && zaman%10==0){
				Point r=pictureBox1.Location;
				r.X+=atılma;
				pictureBox1.Location=r;
				textBox2.Text=(Convert.ToInt16(textBox2.Text)+atılma).ToString();
			}
			if(zaman1<100 && zaman1%10==0){
				Point r1=pictureBox2.Location;
				r1.X+=atılma1;
				pictureBox2.Location=r1;
				textBox1.Text=(Convert.ToInt16(textBox1.Text)+atılma1).ToString();
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			textBox3.Focus();
			label3.Text=MousePosition.X.ToString();
			label4.Text=zaman.ToString();
			zaman++;
			zaman1++;
			label5.Text=zaman1.ToString();
			kos();
			if(zaman1<100)label5.BackColor=Color.Red;else label5.BackColor=Color.Green;
			if(zaman<100)label4.BackColor=Color.Red;else label4.BackColor=Color.Green;
		}

		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			if((int)e.KeyChar==49)
			{
				if(zaman/100!=0){
					atılma=(int)((zaman%10));
					zaman=0;
				}else{
					zaman=0;
					atılma=0;
				}
				if(Convert.ToInt16(textBox2.Text)>=1111){
					timer1.Stop();
					MessageBox.Show("kazanan siyah at...");
				}
			}
			if((int)e.KeyChar==48){
				if(zaman1/100!=0){
					atılma1=(int)(zaman1%10);
					zaman1=0;
				}else {
					zaman1=0;atılma1=0;
				}
				if(Convert.ToInt16(textBox1.Text)>=1111){
					timer1.Stop();MessageBox.Show("kazanan beyaz at...");
				}
			}
		}
		
	}
}
