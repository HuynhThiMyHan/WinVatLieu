namespace DATN_QuanTri
{
    partial class XtraReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.nHANVIENTableAdapter = new DATN_QuanTri.DataSet1TableAdapters.NHANVIENTableAdapter();
            this.phieugiaoTableAdapter1 = new DAL.DataSet1TableAdapters.PHIEUGIAOTableAdapter();
            this.hanghoaTableAdapter1 = new DAL.DataSet1TableAdapters.HANGHOATableAdapter();
            this.phieugiaoTableAdapter2 = new DAL.DataSet1TableAdapters.PHIEUGIAOTableAdapter();
            this.dataSet11 = new DATN_QuanTri.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // phieugiaoTableAdapter1
            // 
            this.phieugiaoTableAdapter1.ClearBeforeFill = true;
            // 
            // hanghoaTableAdapter1
            // 
            this.hanghoaTableAdapter1.ClearBeforeFill = true;
            // 
            // phieugiaoTableAdapter2
            // 
            this.phieugiaoTableAdapter2.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSet11});
            this.DataAdapter = this.phieugiaoTableAdapter1;
            this.DataMember = "NHANVIEN";
            this.DataSource = this.dataSet11;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DAL.DataSet1TableAdapters.PHIEUGIAOTableAdapter phieugiaoTableAdapter1;
        private DAL.DataSet1TableAdapters.HANGHOATableAdapter hanghoaTableAdapter1;
        private DAL.DataSet1TableAdapters.PHIEUGIAOTableAdapter phieugiaoTableAdapter2;
        private DataSet1 dataSet11;
    }
}
