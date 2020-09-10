// Ngày update 8/7/2019
// - Đọc dữ liệu từ file excel vào lưới
// - Lấy dữ liệu từ lưới để hiển thị
// - Cột sau cùng là địa chỉ email nhận thông tin
// Chú ý: Cách này chỉ áp dụng cho win form, không dùng được với web

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using System.IO;
using System.Globalization;
using System.Threading;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;  

namespace SendEmail
{
    public partial class SendEmailExcel : Form
    {    
        
        public SendEmailExcel()
        {
            InitializeComponent();
        }
        private void SendEmailExcel_Load(object sender, EventArgs e)
        {
            txtEmailSender.Text ="";            txtPassSender.Text ="";
            txtSubjectEmail.Text ="";            rtxHeader.Text = "";
            rtxFooter.Text = "";            txtFileName.Text = "";
            btnSendEmail.Enabled = false;
            ChangeLanguage();
            autoFillInfo(); // tự động điền thông tin địa chỉ email, mật khẩu...
            this.AllowDrop = true; //https://www.dotnetcurry.com/ShowArticle.aspx?ID=192
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string tenTapTin ;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                tenTapTin=filePaths[0];
                txtFileName.Text = tenTapTin;
                loadFileDenGrid(tenTapTin);
            }
        }
        private void SendEmailExcel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void ChangeLanguage()
        { // https://documentation.devexpress.com/WindowsForms/9478/Controls-and-Libraries/Editors-and-Simple-Controls/Simple-Editors/Examples/How-to-Change-Current-UI-Culture
          //     Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi");
          //   Localizer.Active = Localizer.CreateDefaultLocalizer();
           Thread.CurrentThread.CurrentCulture = new CultureInfo("vi");
           Thread.CurrentThread.CurrentUICulture = new CultureInfo("vi");
        }
        public static bool IsNumeric(object Expression)
        { // https://stackoverflow.com/questions/894263/identify-if-a-string-is-a-number
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        public static string ConvertDDMMYYYYtoMMDDYYYY(string t)
        {
            string kq = "";
            if (t.Length < 10) return kq; // chỉ xét nếu chiều dài > 9
            t = t.Substring(0, 10); 
            try
            {
                DateTime tmpDate1 = DateTime.ParseExact(t, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces);
                kq = string.Format("{0: MM/dd/yyyy}", tmpDate1);
            }
            catch
            {
                return kq;
            }
         return kq;;
        }
        public bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        { //  https://www.codeproject.com/Articles/13338/Check-If-A-String-Value-Is-Numeric
            Double result;
            return Double.TryParse(val, NumberStyle, System.Globalization.CultureInfo.CurrentCulture, out result);
        }
        private void btnImpExcel_Click(object sender, EventArgs e)
        {
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Chọn tập tin Excel";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Tập tin Excel (*.xls)|*.xls|(*.xlsx)|*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK) fname = fdlg.FileName; else return;
            loadFileDenGrid(fname);
        }
        private void loadFileDenGrid(string tentaptin)
        {
            string inputValue = tentaptin;
            string Ext = Path.GetExtension(inputValue);
            string Name = Path.GetFileName(inputValue);
            txtFileName.Text = tentaptin;
            if (Ext.Equals(".xls") || Ext.Equals(".xlsx"))
                LoadExcelToGrid(tentaptin, Ext, "YES");
            else
                MessageBox.Show("Chỉ hổ trợ tập tin excel"); 
        }
        private void ThemPanelChk()
        {
            palCotHienThi.Controls.Clear();

            Label lbl = new Label { Text = "Check vào trường muốn ẩn" };
            //palCotHienThi.Controls.Remove(lbl);
            lbl.AutoSize = true; lbl.Dock = DockStyle.Top; palCotHienThi.Controls.Add(lbl);

            Panel pal = new Panel();
            CheckBox chkb = new CheckBox();
            //palCotHienThi.Controls.Remove(pal);
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                chkb = new CheckBox { Name = gridView1.Columns[i].FieldName, Text = gridView1.Columns[i].FieldName }; //gridView1.Columns[i].Caption = null do load từ file excel nên chỉ có FieldName, caption column = null
                textBox1.Text = gridView1.Columns[i].FieldName;
                chkb.CheckedChanged += chkb_CheckedChanged;
                chkb.Height = 30;
                chkb.Width = 90;
                chkb.Top = chkb.Height * i + 40;
                pal.Controls.Add(chkb);
            }
            pal.Dock = DockStyle.Fill; pal.AutoScroll = true;
            palCotHienThi.Controls.Add(pal);
        }
        void chkb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked)
                gridView1.Columns.ColumnByFieldName(chk.Name).Visible = false;
            else
                gridView1.Columns.ColumnByFieldName(chk.Name).Visible = true;
        }
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
        private bool coInternet()
        {
            bool kq = false;
            // https://stackoverflow.com/questions/2031824/what-is-the-best-way-to-check-for-internet-connectivity-using-net
            var request = (HttpWebRequest)WebRequest.Create("http://g.cn/generate_204");
            request.UserAgent = "Android";
            request.KeepAlive = false;
            request.Timeout = 1500;
            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.ContentLength == 0 && response.StatusCode == HttpStatusCode.NoContent)
                    { // MessageBox.Show("Connection to internet available");
                        kq = true;
                    }
                    else
                    { // MessageBox.Show("Connection to internet not available");
                    }
                }
            }
            catch
            { //  MessageBox.Show("Connection to internet not available");
            }
            return kq;
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tensheet = listView1.SelectedItems[0].SubItems[1].Text; // https://stackoverflow.com/questions/15091400/get-single-listview-selecteditem
            string fname = txtFileName.Text;
            string Ext = Path.GetExtension(fname);
            string Name = Path.GetFileName(fname);
            txtFileName.Text = fname;
            LoadExcelToGrid(fname, Ext, "YES", tensheet);
        }
        private void LoadExcelToGrid(string tenFileExcel, string moRong, string readHeader, string tenSheetChon = "")
        {
            if (string.IsNullOrEmpty(tenSheetChon))
                FillGridFromExcelSheet(tenFileExcel, moRong, readHeader);
            else
                FillGridFromExcelSheet(tenFileExcel, moRong, readHeader, tenSheetChon);
            btnSendEmail.Enabled = true;
            ChinhHienThiLuoi();// load xong dữ liệu vào lưới thì xử lý
        }
        private void FillGridFromExcelSheet(string FilePath, string ext, string isHader, string tmpExcelSheetName = "")
        {
            string connectionString = "";
            if (ext == ".xls")
            {   //For Excel 97-03
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            }
            else if (ext == ".xlsx")
            {    //For Excel 07 and greater
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR={1}'";
            }
            connectionString = String.Format(connectionString, FilePath, isHader);
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            conn.Open(); //Fetch 1st Sheet Name
            DataTable dtSchema;
            dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string ExcelSheetName = "";

            if (!string.IsNullOrEmpty(tmpExcelSheetName)) // nếu có chỉ định tên sheet
            {
                ExcelSheetName = tmpExcelSheetName + "$"; // thêm lại dấu $ trước khi đọc nội dung sheet2 vì đây là qui định;
                listView1.Focus(); listView1.Items[listView1.SelectedItems[0].Index].Selected = true;
                // https://www.c-sharpcorner.com/UploadFile/mahesh/working-with-listview-in-C-Sharp/
            }
            else
            {
                listView1.Clear();
                listView1.FullRowSelect = true;
                listView1.View = View.Details;
                listView1.Columns.Add("STT");
                listView1.Columns.Add("Tên");
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent); // https://stackoverflow.com/questions/1257500/c-sharp-listview-column-width-auto
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                int i = 1;
                if (dtSchema.Rows.Count > 1) // tự động dò tìm, lấy tên sheet , nếu file có nhiều hơn 2 sheet
                {
                    List<string> danhsachTen = new List<string>();
                    foreach (DataRow row in dtSchema.Rows)
                    { // chỉ lấy tên các sheet trong bảng tính  https://thichchiase.com/thu-thuat/tong-hop-cac-ham-xu-ly-chuoi-trong-lap-trinh-c.html
                        string tName = row[2].ToString(); // index base 0,  cột 2 là cột TABLE_NAME
                        tName = tName.Replace("'", ""); // xóa dấu nháy đơn trong tên nếu có
                        string[] arrListStr = tName.Split('$'); // tách ra làm 2,
                        string tenLay = arrListStr[0]; //  chỉ lấy phần không có dấu $
                        if (!danhsachTen.Contains(tenLay))
                        {
                            danhsachTen.Add(tenLay);
                            listView1.Items.Add(new ListViewItem(new string[] { i.ToString(), tenLay })); // https://stackoverflow.com/questions/11482501/populating-a-listview-multi-column/11486406
                            i = i + 1;
                        }
                    }
                    if (danhsachTen.Count > 1)
                    {
                        ExcelSheetName = danhsachTen.ElementAt(0) + "$"; // thêm lại dấu $ trước khi đọc nội dung sheet2 vì đây là qui định
                        listView1.Focus(); listView1.Items[0].Selected = true; // vì mặc định đọc từ sheet 1, nếu có nhiều sheet, do vậy hiển thị sheet tương ứng đã đọc trong danh sách
                    }
                }
                else
                {
                    ExcelSheetName = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                    string[] arrListStr = ExcelSheetName.Split('$'); // tách ra làm 2,
                    string tenLay = arrListStr[0]; //  chỉ lấy phần không có dấu $
                    listView1.Items.Add(new ListViewItem(new string[] { "1", tenLay })); // https://stackoverflow.com/questions/11482501/populating-a-listview-multi-column/11486406
                    listView1.Focus(); listView1.Items[0].Selected = true; // vì mặc định đọc từ sheet2 , nếu có nhiều sheet, do vậy hiển thị sheet tương ứng đã đọc trong danh sách    
                }
            } // tự động dò tìm, lấy tên sheet
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
            conn.Close();
            conn.Open(); //Read all data of fetched Sheet to a Data Table
            cmd.CommandText = "SELECT * From [" + ExcelSheetName + "]";
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dt);
            conn.Close();
            gridView1.Columns.Clear();   
            ExcelGridView.DataSource = null;
            ExcelGridView.DataSource = dt; //Bind Sheet Data to GridView    
        }
        private bool[] CreateStateCol()
        {  // gridView1.VisibleColumns.Count - đếm tất cả các cột hiển thị trên lưới, bao gồm cả cột checkbox
            // foreach (GridColumn col in gridView1.Columns) // xét từng cột, bao gồm cả cột ẩn, nhưng không xét cột checkbox
            int slCot = gridView1.VisibleColumns.Count-1; //-1 là trừ cột checkbox, chỉ đếm các cột hiển thị ,cột cuối cùng là địa chỉ nhận email , và chú ý có cột check
            bool[] stateCol = new bool[slCot]; // trạng thái cột, cột có gửi dữ liệu hay không, mặc định là gửi  // index mảng động là 0 http://pingpongcode.com/mang-trong-c-sharp [số lượng phần tử máng=base 1]
            int sttCot = 0;
            foreach (GridColumn col in gridView1.Columns) // xét từng cột, tự động bỏ qua cột checkbox
            {
               // string t = col.FieldName;  
                if (col.Visible) // bỏ qua các cột ẩn, chỉ xét các cột hiển thị trên màn hình 
                {
                    string strTieuDeCot = col.FieldName; // gridView1.Columns[i].Caption = null do load từ file excel nên chỉ có FieldName, caption column = null
                    if (strTieuDeCot.IndexOf("*") < 0) //nếu có dấu * thì cột này không gửi thông tin -> không xử lý
                        stateCol[sttCot] = true;
                    else stateCol[sttCot] = false;
                    sttCot = sttCot + 1;
                }
            }
            return stateCol;
        }
        private string[] CreateTieuDeCotEmail() // tiêu đề cột sẽ gửi email
        { // tiêu đề cột = tiêu để sẽ gửi email + (":" hay ":2") + công thức  
            int slCot = gridView1.VisibleColumns.Count-1; //chỉ đếm các cột hiển thị ,cột cuối cùng là địa chỉ nhận email 
            string[] tieudeCotGuiEmail = new string[slCot];
            int sttCot = 0;
            foreach (GridColumn col in gridView1.Columns) // xét từng cột
            {
                if (col.Visible) // bỏ qua các cột ẩn, chỉ xét các cột hiển thị trên màn hình 
                {
                    string strTieuDeCot = col.FieldName; // gridView1.Columns[i].Caption = null do load từ file excel nên chỉ có FieldName, caption column = null
                    if (strTieuDeCot.IndexOf(":") > 0) // nếu có dấu : thì mới tách làm 2
                    {
                        string[] arrListStr = strTieuDeCot.Split(':'); // tách ra làm 2,
                        tieudeCotGuiEmail[sttCot] = arrListStr[0]; //  chỉ lấy phần không có dấu :, lấy từ dấu : trở về trước
                    }
                    else tieudeCotGuiEmail[sttCot] = strTieuDeCot; // không có dấu : thì chỉ có tiêu đề như họ tên, không có công thức
                    sttCot = sttCot + 1;
                }
            }
            return tieudeCotGuiEmail;
        }
        private string[] CreateTieudeCotCongThuc() // tiêu đề công thức gửi email
        { // tiêu đề cột = tiêu để sẽ gửi email + (":" hay ":2") + công thức  
            int slCot = gridView1.VisibleColumns.Count - 1; //chỉ đếm các cột hiển thị ,cột cuối cùng là địa chỉ nhận email 
            string[] tieudeCotCongThuc = new string[slCot]; //  
            int sttCot = 0;
            foreach (GridColumn col in gridView1.Columns) // xét từng cột
            {
                if (col.Visible) // bỏ qua các cột ẩn, chỉ xét các cột hiển thị trên màn hình 
                {
                    string strTieuDeCot = col.FieldName; // gridView1.Columns[i].Caption = null do load từ file excel nên chỉ có FieldName, caption column = null
                    if (strTieuDeCot.IndexOf(":") > 0) // nếu có dấu : thì mới tách làm 2
                    {
                        string[] arrListStr = strTieuDeCot.Split(':'); // tách ra làm 2,
                        tieudeCotCongThuc[sttCot] = arrListStr[1].Substring(1, arrListStr[1].Length - 1);  // sau dấu : 1 khoảng cách là công thức
                    }
                    sttCot = sttCot + 1;
                }
            }
            return tieudeCotCongThuc;
        }
        private string[] CreateDinhDangCot() // chuổi định dạng cột dữ liệu
        { // tiêu đề cột = tiêu để sẽ gửi email + (":" hay ":2") + công thức  
            int slCot = gridView1.VisibleColumns.Count - 1; //chỉ đếm các cột hiển thị ,cột cuối cùng là địa chỉ nhận email 
            string[] dinhDangCot = new string[slCot];
            int sttCot = 0;
            foreach (GridColumn col in gridView1.Columns) // xét từng cột
            {
                if (col.Visible) // bỏ qua các cột ẩn, chỉ xét các cột hiển thị trên màn hình 
                {
                    string strTieuDeCot = col.FieldName; // gridView1.Columns[i].Caption = null do load từ file excel nên chỉ có FieldName, caption column = null
                    if (strTieuDeCot.IndexOf(":2") > 0) dinhDangCot[sttCot] = "n2"; // nếu có định dạng số thì thêm vào định dạng cột
                    else // xem thử cột này có phải là kiểu ngày
                    {
                        string strDuLieuDong1 = gridView1.GetRowCellValue(0, col).ToString();  // lấy dữ liệu thực tế từ dòng dữ liệu đầu tiên/thứ 2 để kiểm tra, nếu trong tiêu đề không có thông tin // dữ liệu dùng để đoán định dạng khi cần
                        if (!string.IsNullOrEmpty(ConvertDDMMYYYYtoMMDDYYYY(strDuLieuDong1)))
                            dinhDangCot[sttCot] = "d";  // nếu chuổi là dữ liệu kiểu ngày dd/mm/yyyy thì sẽ lấy 10 ký tự đại diện cho ngày
                        else if (isNumeric(strDuLieuDong1, System.Globalization.NumberStyles.Float))
                            dinhDangCot[sttCot] = "n0"; // nếu là số, ko định dạng n2 thì cho là n0
                        else dinhDangCot[sttCot] = "text";
                    }
                    sttCot = sttCot + 1;
                }
            }
            return dinhDangCot;
        }
        private void ChinhHienThiLuoi()
        { // sau khi đã nạp dữ liệu vào lưới
            ThemPanelChk(); // thêm panel sau khi đã nạp dữ liệu
            // filter không có icon
            gridView1.OptionsView.ShowAutoFilterRow = true; // https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.OptionsColumnFilter.AutoFilterCondition.property
            gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            // tự động chỉnh độ rộng cột
            gridView1.BestFitColumns();
            gridView1.OptionsView.ColumnAutoWidth = false;
            // thêm cột checkbox để chọn
            gridView1.OptionsSelection.MultiSelect = true;//https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridOptionsSelection.MultiSelectMode.property
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            foreach (GridColumn col in gridView1.Columns)
            { // gán cột readonly và định dạng hiển thị
                col.OptionsColumn.AllowEdit = false; // chỉ đọc dữ liệu trên các cột gridview https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.OptionsColumn.AllowEdit.property
                if (col.ReadOnly) col.AppearanceCell.BackColor = Color.Gray; //https://documentation.devexpress.com/WindowsForms/DevExpress.XtraGrid.Columns.GridColumn.ReadOnly.property
                string dulieuCot = col.FieldName;  //gridView1.Columns[i].Caption = null do load từ file excel nên chỉ có FieldName, caption column = null
                if (dulieuCot.IndexOf(":2") > 0)
                {
                    col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    col.DisplayFormat.FormatString = "n2";
                }
                else  // lấy dữ liệu thực tế từ dòng dữ liệu đầu tiên để kiểm tra
                {
                    dulieuCot = gridView1.GetRowCellValue(0,col).ToString(); // lấy dữ liệu dòng 0, cột đang xét
                    if (isNumeric(dulieuCot, System.Globalization.NumberStyles.Float))
                    {
                        col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        col.DisplayFormat.FormatString = "n0";
                    }
                }
            } //  foreach (GridColumn col in gridView1.Columns)

        }
        private string taoNoiDungGuiEmaiTuGrid(int dong, bool[] stateCol, string[] tieudeCotGuiEmail, string[] tieudeCotCongThuc, string[] dinhDangCot)
        {
            string noidungEmail = "";
            int slCot = gridView1.VisibleColumns.Count - 2; //chỉ đếm các cột hiển thị ,cột cuối cùng là địa chỉ nhận email 
            // trừ 1 - là cột check box trên lưới
            // trừ 1 - là cột sau cùng, địa chỉ email
            int sttCot = 0;
            foreach (GridColumn col in gridView1.Columns) // xét từng cột
            {
                if ((col.Visible)&&(sttCot != slCot) && (stateCol[sttCot])) // chưa đến cột cuối, và cho phép gửi thông tin (cột lưu địa chỉ email), thì mới xử lý
                {
                    string dulieuCot = gridView1.GetRowCellValue(dong, col).ToString();
                    if (!string.IsNullOrEmpty(dulieuCot)) // nếu giá trị khác rỗng thì mới thực hiện, nếu rỗng thì tự động lấy empty
                    {
                        {
                            switch (dinhDangCot[sttCot])  // định dạng dữ liệu nếu có thông tin
                            {
                                case "d":
                                    dulieuCot = dulieuCot.Substring(0, 10);
                                    break;
                                case "n0":
                                    dulieuCot = String.Format("{0:n0}", Convert.ToDouble(dulieuCot));
                                    break;
                                case "n2":
                                    dulieuCot = String.Format("{0:n2}", Convert.ToDouble(dulieuCot));
                                    break;
                            }
                        }
                        noidungEmail = noidungEmail + "<tr><td><b>" + tieudeCotGuiEmail[sttCot] + "</td></b><td>" + tieudeCotCongThuc[sttCot] + "</td><td align='right'>" + dulieuCot + "</td></tr>";
                    }
                    sttCot = sttCot + 1;
                }
            } // cột tiếp theo
            if (!string.IsNullOrEmpty(noidungEmail))
            {
                string TieuDeTable = "<table border=1>"; // tạo bảng  
                noidungEmail = TieuDeTable + noidungEmail + "</table>";
            }
            return noidungEmail;
        }
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if (!coInternet()) { MessageBox.Show("Thông báo", "Kiểm tra lại kết nối internet", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }
            if (cotCuoiKhongCoEmail()) { MessageBox.Show("Thông báo", "Không tìm thấy email ở cột cuối", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }
            int demSLGui=GuiDuLieu();
            if (demSLGui > 0) MessageBox.Show("Đã gửi " + demSLGui.ToString() + " email.");
        }
        private bool cotCuoiKhongCoEmail()
        { // nếu cột cuối trên lưới: không cột email hay không có dòng nào có email  thì thông báo và ngừng
            bool kq = true;
            GridColumn lastColumn = gridView1.VisibleColumns[gridView1.VisibleColumns.Count - 1]; //if (gridView1.VisibleColumns.Count > 0) { //  GridColumn firstColumn = gridView1.VisibleColumns[0];}
            int slDong = gridView1.RowCount;
            int DemThu = 0; // đếm thử có bao nhiêu địa chỉ email trong cột cuối
            for (int i = 0; i < slDong; i++)
            {
                string dcEmailNhan = gridView1.GetRowCellValue(i, lastColumn).ToString();
                if (!IsValidEmail(dcEmailNhan)) dcEmailNhan = ""; // nếu có dữ liệu nhưng không phải địa chỉ email thì trả về empty
                else DemThu = DemThu + 1;
            }
            if (DemThu > 0) kq = false; // nếu có ít nhất 1 địa chỉ email ở cuột cuối thì ok
            return kq;
        }
        
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        { // https://documentation.devexpress.com/WindowsForms/115548/Controls-and-Libraries/Data-Grid/Appearance-and-Conditional-Formatting
            GridView view = sender as GridView;
            bool _mark =false;
            if (view.GetRowCellValue(e.RowHandle, "Email") != DBNull.Value) _mark = true;
            if (e.Column.FieldName == "Email")
            {
                e.Appearance.BackColor = _mark ? Color.LightGreen : Color.LightSalmon;
            }
        }
        private string LayEmailNguoiNhan(int dong)
        {  // lấy email người nhận ở cột cuối cùng trên lưới invisible, dòng đang xét 
            string dcEmailNhan = "";
            GridColumn lastColumn = gridView1.VisibleColumns[gridView1.VisibleColumns.Count - 1]; //if (gridView1.VisibleColumns.Count > 0) { //  GridColumn firstColumn = gridView1.VisibleColumns[0];}
            dcEmailNhan = gridView1.GetRowCellValue(dong, lastColumn).ToString();
            if (!IsValidEmail(dcEmailNhan)) dcEmailNhan = ""; // nếu có dữ liệu nhưng không phải địa chỉ email thì trả về empty
            return dcEmailNhan;
        }
        bool IsValidEmail(string email)
        { //https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void autoFillInfo()
        { //https://laptrinhvb.net/bai-viet/chuyen-de-csharp/---Csharp----Luu-thong-tin-cau-hinh-ung-dung-trong-lap-trinh--Csharp-/dd053dba43853c46.html
            // đọc dữ liệu từ chương trình, nhập vô form
            string tenTaiKhoanEmailGui = SendEmail.Properties.Settings.Default.taikhoangui;
            string tenpassTaiKhoanEmailGui = SendEmail.Properties.Settings.Default.matkhaugui;
            string tieudeEmail = SendEmail.Properties.Settings.Default.tieude;
            string dongdauemail = SendEmail.Properties.Settings.Default.dongdauemail;
            string dongcuoiemail = SendEmail.Properties.Settings.Default.dongcuoiemail;
            txtEmailSender.Text = tenTaiKhoanEmailGui;
            txtPassSender.Text = tenpassTaiKhoanEmailGui;
            txtSubjectEmail.Text = tieudeEmail;
            rtxHeader.Text = dongdauemail;
            rtxFooter.Text = dongcuoiemail;
        }
        private void SendEmailExcel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
                MessageBox.Show(e.Data.GetData(DataFormats.Text).ToString());
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
            }
        }
        private void ExcelGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void ExcelGridView_DragDrop(object sender, DragEventArgs e)
        {
            string tenTapTin;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                tenTapTin = filePaths[0];
                txtFileName.Text = tenTapTin;
                loadFileDenGrid(tenTapTin);
            }
        }
        //////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            string[] dinhDangCot = CreateDinhDangCot(); // định dạng dữ liệu của cột
            int t = 1;
        }

        private int GuiDuLieu()
        {
            btnSendEmail.Enabled = false;
            int demSLGui = 0;
            InforSMTPServer objSMTP = new InforSMTPServer(); // lấy thông tin tên máy chủ SMTP, cổng...
            objSMTP = clsEmail.getInforSMTP(); //lấy thông tin máy chủ SMTP

            string diaChiEmailGui = txtEmailSender.Text;
            string matKhauEmailGui = txtPassSender.Text;
            string tieudeEmail = txtSubjectEmail.Text;
            string dongDauEmail = rtxHeader.Text;
            string dongCuoiEmail = rtxFooter.Text;
            bool[] stateCol = CreateStateCol(); // trạng thái cột, cột có gửi dữ liệu hay không, mặc định là gửi
            string[] tieudeCotGuiEmail = CreateTieuDeCotEmail(); // tiêu đề sẽ gửi email
            string[] tieudeCotCongThuc = CreateTieudeCotCongThuc(); // công thức sẽ gửi email, tách từ tiêu đề
            string[] dinhDangCot = CreateDinhDangCot(); // định dạng dữ liệu của cột

            bool coChonTrenLuoi = false;
            int[] danhsachIndexDongChon = gridView1.GetSelectedRows();
            if (gridView1.GetSelectedRows().Count() > 0) coChonTrenLuoi = true;

            int slDong = gridView1.RowCount - 1;
            for (int i = 0; i < slDong; i++) // xét từng dòng
            {
                string strDCEmailNhan = LayEmailNguoiNhan(i); // dòng nào không có địa chỉ email người nhận thì bỏ qua, không xử lý số liệu, cho nhanh
                string noidungEmail = "";
                if (!string.IsNullOrEmpty(strDCEmailNhan))
                {  // nếu có chọn thì kiểm tra dòng này có được chọn để gửi thông tin hay không  https://stackoverflow.com/questions/7867377/checking-if-a-string-array-contains-a-value-and-if-so-getting-its-position
                    if (!coChonTrenLuoi)
                        noidungEmail = taoNoiDungGuiEmaiTuGrid(i, stateCol, tieudeCotGuiEmail, tieudeCotCongThuc, dinhDangCot); // tạo dữ liệu dòng i, kèm trạng thái cột...
                    else
                    {
                        int pos = Array.IndexOf(danhsachIndexDongChon, i);
                        if (pos > -1) noidungEmail = taoNoiDungGuiEmaiTuGrid(i, stateCol, tieudeCotGuiEmail, tieudeCotCongThuc, dinhDangCot); // nếu dòng hiện tại có trong danh sách được chọn, tạo dữ liệu dòng i, kèm trạng thái cột... 
                    }
                    if (!string.IsNullOrEmpty(noidungEmail))
                    {
                        clsEmail.GoiMailSMTP(objSMTP, diaChiEmailGui, matKhauEmailGui, strDCEmailNhan, tieudeEmail, dongDauEmail, noidungEmail, dongCuoiEmail);
                        demSLGui = demSLGui + 1;
                    }
                 }
            } // xét từng dòng, từng người
            // txtFileName.Text = "";
            return demSLGui;
        }
        

        

       

        


      



    }
}
