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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.urunEklePencere = new DevExpress.XtraLayout.LayoutControl();
            this.urunEkleStoktb = new System.Windows.Forms.TextBox();
            this.urunEkleIndirimOranitb = new System.Windows.Forms.TextBox();
            this.urunEkleBAdettb = new System.Windows.Forms.TextBox();
            this.urunEkleFiyatb = new System.Windows.Forms.TextBox();
            this.urunEkleTurtb = new System.Windows.Forms.TextBox();
            this.urunEkleAdtb = new System.Windows.Forms.TextBox();
            this.urunEkleMarkatb = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.urunMarkaEklelbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.urunEkleAdlbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.urunEkleTurlbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.urunEkleFiyatlbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.urunEkleBAdetlbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.urunEkleIndirimOranilbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.urunEkleStoklbl = new DevExpress.XtraLayout.LayoutControlItem();
            this.UrunEkleBtn = new System.Windows.Forms.Button();
            this.urunListe = new DevExpress.XtraGrid.GridControl();
            this.UrunlerSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTür = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimliFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KullanicilarSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
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
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunEklePencere)).BeginInit();
            this.urunEklePencere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunMarkaEklelbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleAdlbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleTurlbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleFiyatlbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleBAdetlbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleIndirimOranilbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleStoklbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.urunEklePencere);
            this.fluentDesignFormContainer1.Controls.Add(this.UrunEkleBtn);
            this.fluentDesignFormContainer1.Controls.Add(this.urunListe);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(252, 30);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(720, 525);
            this.fluentDesignFormContainer1.TabIndex = 0;
            this.fluentDesignFormContainer1.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // urunEklePencere
            // 
            this.urunEklePencere.Controls.Add(this.urunEkleStoktb);
            this.urunEklePencere.Controls.Add(this.urunEkleIndirimOranitb);
            this.urunEklePencere.Controls.Add(this.urunEkleBAdettb);
            this.urunEklePencere.Controls.Add(this.urunEkleFiyatb);
            this.urunEklePencere.Controls.Add(this.urunEkleTurtb);
            this.urunEklePencere.Controls.Add(this.urunEkleAdtb);
            this.urunEklePencere.Controls.Add(this.urunEkleMarkatb);
            this.urunEklePencere.Dock = System.Windows.Forms.DockStyle.Left;
            this.urunEklePencere.Location = new System.Drawing.Point(0, 0);
            this.urunEklePencere.Name = "urunEklePencere";
            this.urunEklePencere.Root = this.layoutControlGroup1;
            this.urunEklePencere.Size = new System.Drawing.Size(241, 525);
            this.urunEklePencere.TabIndex = 3;
            this.urunEklePencere.Text = "layoutControl1";
            // 
            // urunEkleStoktb
            // 
            this.urunEkleStoktb.Location = new System.Drawing.Point(121, 186);
            this.urunEkleStoktb.Name = "urunEkleStoktb";
            this.urunEkleStoktb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleStoktb.TabIndex = 11;
            // 
            // urunEkleIndirimOranitb
            // 
            this.urunEkleIndirimOranitb.Location = new System.Drawing.Point(121, 157);
            this.urunEkleIndirimOranitb.Name = "urunEkleIndirimOranitb";
            this.urunEkleIndirimOranitb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleIndirimOranitb.TabIndex = 10;
            // 
            // urunEkleBAdettb
            // 
            this.urunEkleBAdettb.Location = new System.Drawing.Point(121, 128);
            this.urunEkleBAdettb.Name = "urunEkleBAdettb";
            this.urunEkleBAdettb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleBAdettb.TabIndex = 9;
            // 
            // urunEkleFiyatb
            // 
            this.urunEkleFiyatb.Location = new System.Drawing.Point(121, 99);
            this.urunEkleFiyatb.Name = "urunEkleFiyatb";
            this.urunEkleFiyatb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleFiyatb.TabIndex = 8;
            // 
            // urunEkleTurtb
            // 
            this.urunEkleTurtb.Location = new System.Drawing.Point(121, 70);
            this.urunEkleTurtb.Name = "urunEkleTurtb";
            this.urunEkleTurtb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleTurtb.TabIndex = 7;
            // 
            // urunEkleAdtb
            // 
            this.urunEkleAdtb.Location = new System.Drawing.Point(121, 41);
            this.urunEkleAdtb.Name = "urunEkleAdtb";
            this.urunEkleAdtb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleAdtb.TabIndex = 6;
            // 
            // urunEkleMarkatb
            // 
            this.urunEkleMarkatb.Location = new System.Drawing.Point(121, 12);
            this.urunEkleMarkatb.Name = "urunEkleMarkatb";
            this.urunEkleMarkatb.Size = new System.Drawing.Size(108, 25);
            this.urunEkleMarkatb.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.urunMarkaEklelbl,
            this.urunEkleAdlbl,
            this.urunEkleTurlbl,
            this.urunEkleFiyatlbl,
            this.urunEkleBAdetlbl,
            this.urunEkleIndirimOranilbl,
            this.urunEkleStoklbl});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(241, 582);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // urunMarkaEklelbl
            // 
            this.urunMarkaEklelbl.Control = this.urunEkleMarkatb;
            this.urunMarkaEklelbl.Location = new System.Drawing.Point(0, 0);
            this.urunMarkaEklelbl.Name = "urunMarkaEklelbl";
            this.urunMarkaEklelbl.Size = new System.Drawing.Size(221, 29);
            this.urunMarkaEklelbl.Text = "Ürün Markası";
            this.urunMarkaEklelbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // urunEkleAdlbl
            // 
            this.urunEkleAdlbl.Control = this.urunEkleAdtb;
            this.urunEkleAdlbl.Location = new System.Drawing.Point(0, 29);
            this.urunEkleAdlbl.Name = "urunEkleAdlbl";
            this.urunEkleAdlbl.Size = new System.Drawing.Size(221, 29);
            this.urunEkleAdlbl.Text = "Ürün Adı";
            this.urunEkleAdlbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // urunEkleTurlbl
            // 
            this.urunEkleTurlbl.Control = this.urunEkleTurtb;
            this.urunEkleTurlbl.Location = new System.Drawing.Point(0, 58);
            this.urunEkleTurlbl.Name = "urunEkleTurlbl";
            this.urunEkleTurlbl.Size = new System.Drawing.Size(221, 29);
            this.urunEkleTurlbl.Text = "Ürün Türü";
            this.urunEkleTurlbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // urunEkleFiyatlbl
            // 
            this.urunEkleFiyatlbl.Control = this.urunEkleFiyatb;
            this.urunEkleFiyatlbl.Location = new System.Drawing.Point(0, 87);
            this.urunEkleFiyatlbl.Name = "urunEkleFiyatlbl";
            this.urunEkleFiyatlbl.Size = new System.Drawing.Size(221, 29);
            this.urunEkleFiyatlbl.Text = "Ürün Fiyatı";
            this.urunEkleFiyatlbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // urunEkleBAdetlbl
            // 
            this.urunEkleBAdetlbl.Control = this.urunEkleBAdettb;
            this.urunEkleBAdetlbl.Location = new System.Drawing.Point(0, 116);
            this.urunEkleBAdetlbl.Name = "urunEkleBAdetlbl";
            this.urunEkleBAdetlbl.Size = new System.Drawing.Size(221, 29);
            this.urunEkleBAdetlbl.Text = "Ürün Birim Adeti";
            this.urunEkleBAdetlbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // urunEkleIndirimOranilbl
            // 
            this.urunEkleIndirimOranilbl.Control = this.urunEkleIndirimOranitb;
            this.urunEkleIndirimOranilbl.Location = new System.Drawing.Point(0, 145);
            this.urunEkleIndirimOranilbl.Name = "urunEkleIndirimOranilbl";
            this.urunEkleIndirimOranilbl.Size = new System.Drawing.Size(221, 29);
            this.urunEkleIndirimOranilbl.Text = "Ürün Indirim Oranı";
            this.urunEkleIndirimOranilbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // urunEkleStoklbl
            // 
            this.urunEkleStoklbl.Control = this.urunEkleStoktb;
            this.urunEkleStoklbl.Location = new System.Drawing.Point(0, 174);
            this.urunEkleStoklbl.Name = "urunEkleStoklbl";
            this.urunEkleStoklbl.Size = new System.Drawing.Size(221, 331);
            this.urunEkleStoklbl.Text = "Ürün Stok Adeti";
            this.urunEkleStoklbl.TextSize = new System.Drawing.Size(106, 16);
            // 
            // UrunEkleBtn
            // 
            this.UrunEkleBtn.Location = new System.Drawing.Point(247, 12);
            this.UrunEkleBtn.Name = "UrunEkleBtn";
            this.UrunEkleBtn.Size = new System.Drawing.Size(96, 57);
            this.UrunEkleBtn.TabIndex = 2;
            this.UrunEkleBtn.Text = "Ekle";
            this.UrunEkleBtn.UseVisualStyleBackColor = true;
            this.UrunEkleBtn.Click += new System.EventHandler(this.UrunEkleBtn_Click);
            // 
            // urunListe
            // 
            this.urunListe.DataMember = "Query";
            this.urunListe.DataSource = this.UrunlerSource;
            this.urunListe.Location = new System.Drawing.Point(5, 12);
            this.urunListe.MainView = this.gridView1;
            this.urunListe.Name = "urunListe";
            this.urunListe.Size = new System.Drawing.Size(703, 469);
            this.urunListe.TabIndex = 0;
            this.urunListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.urunListe.Visible = false;
            // 
            // UrunlerSource
            // 
            this.UrunlerSource.ConnectionName = "database";
            this.UrunlerSource.Name = "UrunlerSource";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "SELECT * FROM Urunler";
            this.UrunlerSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.UrunlerSource.ResultSchemaSerializable = resources.GetString("UrunlerSource.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMarka,
            this.colAd,
            this.colTür,
            this.colFiyat,
            this.colBirimFiyat,
            this.colIndirimOrani,
            this.colIndirimliFiyat,
            this.colStokMiktari});
            this.gridView1.GridControl = this.urunListe;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 41;
            // 
            // colMarka
            // 
            this.colMarka.FieldName = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 1;
            this.colMarka.Width = 80;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 2;
            this.colAd.Width = 80;
            // 
            // colTür
            // 
            this.colTür.FieldName = "Tür";
            this.colTür.Name = "colTür";
            this.colTür.Visible = true;
            this.colTür.VisibleIndex = 3;
            this.colTür.Width = 68;
            // 
            // colFiyat
            // 
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 4;
            this.colFiyat.Width = 55;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 5;
            this.colBirimFiyat.Width = 88;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.Visible = true;
            this.colIndirimOrani.VisibleIndex = 6;
            this.colIndirimOrani.Width = 62;
            // 
            // colIndirimliFiyat
            // 
            this.colIndirimliFiyat.FieldName = "IndirimliFiyat";
            this.colIndirimliFiyat.Name = "colIndirimliFiyat";
            this.colIndirimliFiyat.Visible = true;
            this.colIndirimliFiyat.VisibleIndex = 7;
            this.colIndirimliFiyat.Width = 97;
            // 
            // colStokMiktari
            // 
            this.colStokMiktari.FieldName = "StokMiktari";
            this.colStokMiktari.Name = "colStokMiktari";
            this.colStokMiktari.Visible = true;
            this.colStokMiktari.VisibleIndex = 8;
            this.colStokMiktari.Width = 121;
            // 
            // KullanicilarSource
            // 
            this.KullanicilarSource.ConnectionName = "database";
            this.KullanicilarSource.Name = "KullanicilarSource";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = "SELECT * FROM Kullanicilar";
            this.KullanicilarSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.KullanicilarSource.ResultSchemaSerializable = resources.GetString("KullanicilarSource.ResultSchemaSerializable");
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
            // urunListele
            // 
            this.urunListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("urunListele.ImageOptions.Image")));
            this.urunListele.Name = "urunListele";
            this.urunListele.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunListele.Text = "Listele";
            this.urunListele.Click += new System.EventHandler(this.urunListele_Click);
            // 
            // urunEkle
            // 
            this.urunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("urunEkle.ImageOptions.Image")));
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunEkle.Text = "Ekle";
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // urunDuzenle
            // 
            this.urunDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("urunDuzenle.ImageOptions.Image")));
            this.urunDuzenle.Name = "urunDuzenle";
            this.urunDuzenle.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.urunDuzenle.Text = "Düzenle";
            this.urunDuzenle.Click += new System.EventHandler(this.urunDuzenle_Click);
            // 
            // urunSil
            // 
            this.urunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("urunSil.ImageOptions.Image")));
            this.urunSil.Name = "urunSil";
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
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunEklePencere)).EndInit();
            this.urunEklePencere.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunMarkaEklelbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleAdlbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleTurlbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleFiyatlbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleBAdetlbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleIndirimOranilbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEkleStoklbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.DataAccess.Sql.SqlDataSource KullanicilarSource;
        private DevExpress.DataAccess.Sql.SqlDataSource UrunlerSource;
        private DevExpress.XtraGrid.GridControl urunListe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colTür;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimliFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private System.Windows.Forms.Button UrunEkleBtn;
        private DevExpress.XtraLayout.LayoutControl urunEklePencere;
        private System.Windows.Forms.TextBox urunEkleStoktb;
        private System.Windows.Forms.TextBox urunEkleIndirimOranitb;
        private System.Windows.Forms.TextBox urunEkleBAdettb;
        private System.Windows.Forms.TextBox urunEkleFiyatb;
        private System.Windows.Forms.TextBox urunEkleTurtb;
        private System.Windows.Forms.TextBox urunEkleAdtb;
        private System.Windows.Forms.TextBox urunEkleMarkatb;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem urunMarkaEklelbl;
        private DevExpress.XtraLayout.LayoutControlItem urunEkleAdlbl;
        private DevExpress.XtraLayout.LayoutControlItem urunEkleTurlbl;
        private DevExpress.XtraLayout.LayoutControlItem urunEkleFiyatlbl;
        private DevExpress.XtraLayout.LayoutControlItem urunEkleBAdetlbl;
        private DevExpress.XtraLayout.LayoutControlItem urunEkleIndirimOranilbl;
        private DevExpress.XtraLayout.LayoutControlItem urunEkleStoklbl;
    }
}

