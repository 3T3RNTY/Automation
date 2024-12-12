namespace Automation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.calıcanMainGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.calisanListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.calisanEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.calisanDuzenle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.calisanSil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.urunListele = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.urunEkle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.urunDuzenle = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.urunSil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(252, 30);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(720, 525);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.calıcanMainGroup,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 202;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(252, 525);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // calıcanMainGroup
            // 
            this.calıcanMainGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.calisanListele,
            this.calisanEkle,
            this.calisanDuzenle,
            this.calisanSil,
            this.accordionControlSeparator1});
            this.calıcanMainGroup.Expanded = true;
            this.calıcanMainGroup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("calıcanMainGroup.ImageOptions.Image")));
            this.calıcanMainGroup.Name = "calıcanMainGroup";
            this.calıcanMainGroup.Text = "Çalışanlar";
            this.calıcanMainGroup.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // calisanListele
            // 
            this.calisanListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("calisanListele.ImageOptions.Image")));
            this.calisanListele.Name = "calisanListele";
            this.calisanListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.calisanListele.Text = "Listele";
            this.calisanListele.Click += new System.EventHandler(this.calisanListele_Click);
            // 
            // calisanEkle
            // 
            this.calisanEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("calisanEkle.ImageOptions.Image")));
            this.calisanEkle.Name = "calisanEkle";
            this.calisanEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.calisanEkle.Text = "Ekle";
            this.calisanEkle.Click += new System.EventHandler(this.calisanEkle_Click);
            // 
            // calisanDuzenle
            // 
            this.calisanDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("calisanDuzenle.ImageOptions.Image")));
            this.calisanDuzenle.Name = "calisanDuzenle";
            this.calisanDuzenle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.calisanDuzenle.Text = "Düzenle";
            this.calisanDuzenle.Click += new System.EventHandler(this.calisanDuzenle_Click);
            // 
            // calisanSil
            // 
            this.calisanSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("calisanSil.ImageOptions.Image")));
            this.calisanSil.Name = "calisanSil";
            this.calisanSil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.calisanSil.Text = "Sil";
            this.calisanSil.Click += new System.EventHandler(this.calisanSil_Click);
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.urunListele,
            this.urunEkle,
            this.urunDuzenle,
            this.urunSil});
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Ürünler";
            this.accordionControlElement6.Click += new System.EventHandler(this.accordionControlElement6_Click);
            // 
            // accordionControlElement7
            // 
            this.urunListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement7.ImageOptions.Image")));
            this.urunListele.Name = "accordionControlElement7";
            this.urunListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunListele.Text = "Listele";
            this.urunListele.Click += new System.EventHandler(this.urunListele_Click);
            // 
            // accordionControlElement8
            // 
            this.urunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement8.ImageOptions.Image")));
            this.urunEkle.Name = "accordionControlElement8";
            this.urunEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunEkle.Text = "Ekle";
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // accordionControlElement11
            // 
            this.urunDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement11.ImageOptions.Image")));
            this.urunDuzenle.Name = "accordionControlElement11";
            this.urunDuzenle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunDuzenle.Text = "Düzenle";
            this.urunDuzenle.Click += new System.EventHandler(this.urunDuzenle_Click);
            // 
            // accordionControlElement9
            // 
            this.urunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement9.ImageOptions.Image")));
            this.urunSil.Name = "accordionControlElement9";
            this.urunSil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunSil.Text = "Sil";
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(972, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Element5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 555);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Ana Menü";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement calıcanMainGroup;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement calisanListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement calisanEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement urunListele;
        private DevExpress.XtraBars.Navigation.AccordionControlElement urunEkle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement calisanSil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement calisanDuzenle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement urunDuzenle;
        private DevExpress.XtraBars.Navigation.AccordionControlElement urunSil;
    }
}

