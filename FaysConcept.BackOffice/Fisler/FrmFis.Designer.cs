﻿namespace FaysConcept.BackOffice.Fisler
{
    partial class FrmFis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFis));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.grpMenu = new DevExpress.XtraEditors.GroupControl();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btncarihareket = new DevExpress.XtraEditors.SimpleButton();
            this.btnkopyala = new DevExpress.XtraEditors.SimpleButton();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnduzenle = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlFisler = new DevExpress.XtraGrid.GridControl();
            this.gridViewFisler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.imgmenu = new System.Windows.Forms.ImageList(this.components);
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barAlisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            this.barSatisFaturasi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).BeginInit();
            this.grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("lblBaslik.Appearance.Image")));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImage = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1499, 59);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Fiş Hareketleri";
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.dropDownButton1);
            this.grpMenu.Controls.Add(this.btnkapat);
            this.grpMenu.Controls.Add(this.btnguncelle);
            this.grpMenu.Controls.Add(this.btncarihareket);
            this.grpMenu.Controls.Add(this.btnkopyala);
            this.grpMenu.Controls.Add(this.btnsil);
            this.grpMenu.Controls.Add(this.btnduzenle);
            this.grpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMenu.Location = new System.Drawing.Point(0, 742);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1499, 69);
            this.grpMenu.TabIndex = 3;
            this.grpMenu.Text = "Menü";
            // 
            // btnkapat
            // 
            this.btnkapat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkapat.ImageOptions.ImageIndex = 5;
            this.btnkapat.ImageOptions.ImageList = this.imgmenu;
            this.btnkapat.Location = new System.Drawing.Point(1400, 22);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(87, 42);
            this.btnkapat.TabIndex = 4;
            this.btnkapat.Text = "Kapat";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnguncelle.ImageOptions.ImageIndex = 17;
            this.btnguncelle.ImageOptions.ImageList = this.imgmenu;
            this.btnguncelle.Location = new System.Drawing.Point(492, 23);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(87, 42);
            this.btnguncelle.TabIndex = 4;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btncarihareket
            // 
            this.btncarihareket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btncarihareket.ImageOptions.ImageIndex = 3;
            this.btncarihareket.Location = new System.Drawing.Point(384, 23);
            this.btncarihareket.Name = "btncarihareket";
            this.btncarihareket.Size = new System.Drawing.Size(102, 42);
            this.btncarihareket.TabIndex = 4;
            this.btncarihareket.Text = "Cari Durum";
            // 
            // btnkopyala
            // 
            this.btnkopyala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnkopyala.ImageOptions.ImageIndex = 3;
            this.btnkopyala.Location = new System.Drawing.Point(291, 23);
            this.btnkopyala.Name = "btnkopyala";
            this.btnkopyala.Size = new System.Drawing.Size(87, 42);
            this.btnkopyala.TabIndex = 4;
            this.btnkopyala.Text = "Kopyala";
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsil.ImageOptions.ImageIndex = 13;
            this.btnsil.ImageOptions.ImageList = this.imgmenu;
            this.btnsil.Location = new System.Drawing.Point(198, 23);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(87, 42);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnduzenle.ImageOptions.ImageIndex = 14;
            this.btnduzenle.ImageOptions.ImageList = this.imgmenu;
            this.btnduzenle.Location = new System.Drawing.Point(105, 23);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(87, 42);
            this.btnduzenle.TabIndex = 3;
            this.btnduzenle.Text = "Düzenle";
            // 
            // gridControlFisler
            // 
            this.gridControlFisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFisler.Location = new System.Drawing.Point(0, 59);
            this.gridControlFisler.MainView = this.gridViewFisler;
            this.gridControlFisler.Name = "gridControlFisler";
            this.gridControlFisler.Size = new System.Drawing.Size(1499, 683);
            this.gridControlFisler.TabIndex = 4;
            this.gridControlFisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFisler});
            // 
            // gridViewFisler
            // 
            this.gridViewFisler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colCariKodu,
            this.colCariAdi,
            this.colBelgeNo,
            this.colTarih,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani,
            this.colIskontoTutar,
            this.colToplamTutar,
            this.colAciklama});
            this.gridViewFisler.GridControl = this.gridControlFisler;
            this.gridViewFisler.Name = "gridViewFisler";
            this.gridViewFisler.OptionsView.ShowAutoFilterRow = true;
            // 
            // imgmenu
            // 
            this.imgmenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgmenu.ImageStream")));
            this.imgmenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgmenu.Images.SetKeyName(0, "Alım Faturası.fw.png");
            this.imgmenu.Images.SetKeyName(1, "arrow_left_red.png");
            this.imgmenu.Images.SetKeyName(2, "brush.png");
            this.imgmenu.Images.SetKeyName(3, "delete.png");
            this.imgmenu.Images.SetKeyName(4, "factory.png");
            this.imgmenu.Images.SetKeyName(5, "folder_out.png");
            this.imgmenu.Images.SetKeyName(6, "funnel.png");
            this.imgmenu.Images.SetKeyName(7, "funnel_delete.png");
            this.imgmenu.Images.SetKeyName(8, "İade Faturaları.png");
            this.imgmenu.Images.SetKeyName(9, "money.png");
            this.imgmenu.Images.SetKeyName(10, "money48.png");
            this.imgmenu.Images.SetKeyName(11, "note.png");
            this.imgmenu.Images.SetKeyName(12, "note_add.png");
            this.imgmenu.Images.SetKeyName(13, "note_delete.png");
            this.imgmenu.Images.SetKeyName(14, "note_edit.png");
            this.imgmenu.Images.SetKeyName(15, "note_information.png");
            this.imgmenu.Images.SetKeyName(16, "note_ok.png");
            this.imgmenu.Images.SetKeyName(17, "refresh.png");
            this.imgmenu.Images.SetKeyName(18, "safe.png");
            this.imgmenu.Images.SetKeyName(19, "Satış Faturası.fw.png");
            this.imgmenu.Images.SetKeyName(20, "scroll.png");
            this.imgmenu.Images.SetKeyName(21, "shopping_basket.png");
            this.imgmenu.Images.SetKeyName(22, "shopping_cart.png");
            this.imgmenu.Images.SetKeyName(23, "ticket_blue.png");
            this.imgmenu.Images.SetKeyName(24, "user.png");
            this.imgmenu.Images.SetKeyName(25, "user_headset.png");
            this.imgmenu.Images.SetKeyName(26, "view.png");
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colFisKodu
            // 
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 1;
            // 
            // colFisTuru
            // 
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 2;
            // 
            // colCariKodu
            // 
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 3;
            // 
            // colCariAdi
            // 
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 4;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 5;
            // 
            // colTarih
            // 
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 6;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.Visible = true;
            this.colPlasiyerKodu.VisibleIndex = 7;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.Visible = true;
            this.colPlasiyerAdi.VisibleIndex = 8;
            // 
            // colIskontoOrani
            // 
            this.colIskontoOrani.FieldName = "IskontoOrani";
            this.colIskontoOrani.Name = "colIskontoOrani";
            this.colIskontoOrani.Visible = true;
            this.colIskontoOrani.VisibleIndex = 9;
            // 
            // colIskontoTutar
            // 
            this.colIskontoTutar.FieldName = "IskontoTutar";
            this.colIskontoTutar.Name = "colIskontoTutar";
            this.colIskontoTutar.Visible = true;
            this.colIskontoTutar.VisibleIndex = 10;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 11;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 12;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.ImageIndex = 12;
            this.dropDownButton1.ImageOptions.ImageList = this.imgmenu;
            this.dropDownButton1.Location = new System.Drawing.Point(12, 22);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(87, 43);
            this.dropDownButton1.TabIndex = 5;
            this.dropDownButton1.Text = "Ekle";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAlisFaturasi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSatisFaturasi)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAlisFaturasi,
            this.barSatisFaturasi});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 811);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1499, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 811);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1499, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 811);
            // 
            // barAlisFaturasi
            // 
            this.barAlisFaturasi.Caption = "Alış Faturası";
            this.barAlisFaturasi.Id = 0;
            this.barAlisFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAlisFaturasi.ImageOptions.Image")));
            this.barAlisFaturasi.Name = "barAlisFaturasi";
            // 
            // barSatisFaturasi
            // 
            this.barSatisFaturasi.Caption = "Satış Faturası";
            this.barSatisFaturasi.Id = 1;
            this.barSatisFaturasi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSatisFaturasi.ImageOptions.Image")));
            this.barSatisFaturasi.Name = "barSatisFaturasi";
            // 
            // FrmFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 811);
            this.Controls.Add(this.gridControlFisler);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFis";
            this.Load += new System.EventHandler(this.FrmFis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMenu)).EndInit();
            this.grpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl grpMenu;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btncarihareket;
        private DevExpress.XtraEditors.SimpleButton btnkopyala;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnduzenle;
        private DevExpress.XtraGrid.GridControl gridControlFisler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFisler;
        public System.Windows.Forms.ImageList imgmenu;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barAlisFaturasi;
        private DevExpress.XtraBars.BarButtonItem barSatisFaturasi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}