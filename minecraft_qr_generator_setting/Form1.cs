using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ZXing;
using ZXing.QrCode;
using System.Configuration;
using minecraft_qr_generator_setting.Properties;

namespace minecraft_qr_generator_setting
{
    public partial class Form1 : Form
    {
        private String userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private String iniDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)+"\\mcqr\\settings.ini";
        private bool running = false;
        private mcqr_dialog.dialog_yesno form = new mcqr_dialog.dialog_yesno();

        public static String GetPathWithoutExtension(String path)
        {
            var extension = Path.GetExtension(path);
            if (String.IsNullOrEmpty(extension))
            {
                return path;
            }
            return path.Replace(extension, String.Empty);
        }

        public Form1()
        {
            InitializeComponent();

            try
            {
                if (!ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).HasFile)
                    Settings.Default.Upgrade();
            }
            catch
            {

            }

            DescriptionLabel.Text = "このソフトでは、値を入れることで\n簡単にQRコードをMinecraftの中に\n生成することができます。";

            AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();
            Version ver = assembly.Version;

            VersionLabel.Text = "Build " + ver.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(userProfile+"\\mcqr");
            StreamWriter writer = new StreamWriter(userProfile+"\\mcqr\\settings.ini", false, Encoding.Default);
            writer.Close();
            writer.Dispose();

            int BlockNameLength = Properties.Settings.Default.BlockName.Length;
            int BlockIDLength = Properties.Settings.Default.BlockID.Length;
            int BackGroundBlockNameLength = Properties.Settings.Default.BackGroundBlockName.Length;
            int BackGroundBlockIDLength = Properties.Settings.Default.BackGroundBlockID.Length;
            int InputFilePathLength = Properties.Settings.Default.InputFilePath.Length;
            int OutputPathPathLength = Properties.Settings.Default.OutputPath.Length;
            int xLength = Properties.Settings.Default.x.Length;
            int yLength = Properties.Settings.Default.y.Length;
            int zLength = Properties.Settings.Default.z.Length;
            int modeLength = Properties.Settings.Default.mode.Length;
            int editionLength = Properties.Settings.Default.edition.Length;
            int AppFullPathLength = Properties.Settings.Default.AppFullPath.Length;

            if (BlockNameLength != 0 && BlockIDLength != 0 && BackGroundBlockNameLength != 0 && BackGroundBlockIDLength != 0 && InputFilePathLength != 0 && OutputPathPathLength != 0 && xLength != 0 && yLength != 0 && zLength != 0 && modeLength != 0 && editionLength != 0 && AppFullPathLength != 0)
            {
                InputFilePathBox.Text = Properties.Settings.Default.InputFilePath;
                OutputPathBox.Text = Properties.Settings.Default.OutputPath;
                xBox.Text = Properties.Settings.Default.x;
                yBox.Text = Properties.Settings.Default.y;
                zBox.Text = Properties.Settings.Default.z;
                modeBox.Text = Properties.Settings.Default.mode;
                EditionBox.Text = Properties.Settings.Default.edition;
                AppFullPathBox.Text = Properties.Settings.Default.AppFullPath;
                BlockNameBox.Text = Properties.Settings.Default.BlockName;
                BlockIDBox.Text = Properties.Settings.Default.BlockID;
                BackGroundBlockNameBox.Text = Properties.Settings.Default.BackGroundBlockName;
                BackGroundBlockIDBox.Text = Properties.Settings.Default.BackGroundBlockID;
            }
        }

        public async Task SaveSettings()
        {

            StreamWriter writer = new StreamWriter(iniDir, false, Encoding.Default);
            writer.WriteLine("[Data]");
            writer.WriteLine("InputFilePath =" + InputFilePathBox.Text);
            writer.WriteLine("OutputPath =" + OutputPathBox.Text);
            writer.WriteLine("x=" + xBox.Text);
            writer.WriteLine("y=" + yBox.Text);
            writer.WriteLine("z=" + zBox.Text);
            writer.WriteLine("mode=" + modeBox.Text);
            writer.WriteLine("edition=" + EditionBox.Text);
            writer.WriteLine("BlockName=" + BlockNameBox.Text);
            writer.WriteLine("BlockID=" + BlockIDBox.Text);
            writer.WriteLine("BackGroundBlockName=" + BackGroundBlockNameBox.Text);
            writer.WriteLine("BackGroundBlockID=" + BackGroundBlockIDBox.Text);
            writer.Close();
            writer.Dispose();

            Properties.Settings.Default.iniPath = iniDir;
            Properties.Settings.Default.InputFilePath = InputFilePathBox.Text;
            Properties.Settings.Default.OutputPath = OutputPathBox.Text;
            Properties.Settings.Default.x = xBox.Text;
            Properties.Settings.Default.y = yBox.Text;
            Properties.Settings.Default.z = zBox.Text;
            Properties.Settings.Default.mode = modeBox.Text;
            Properties.Settings.Default.edition = EditionBox.Text;
            Properties.Settings.Default.AppFullPath = AppFullPathBox.Text;
            Properties.Settings.Default.BlockName = BlockNameBox.Text;
            Properties.Settings.Default.BlockID = BlockIDBox.Text;
            Properties.Settings.Default.BackGroundBlockName = BackGroundBlockNameBox.Text;
            Properties.Settings.Default.BackGroundBlockID = BackGroundBlockIDBox.Text;
            Properties.Settings.Default.Save();

            await Task.Delay(3000);
        }

        private async Task<string> Run()
        {
            // 拡張子が登録されているファイルを指定
            ProcessStartInfo psInfo = new ProcessStartInfo();
            psInfo.FileName = AppFullPathBox.Text; // 実行するファイル
            psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
            Process p = Process.Start(psInfo);
            p.WaitForExit();
            try
            {
                File.Delete(GetPathWithoutExtension(OutputPathBox.Text) + ".png");
                File.Delete(GetPathWithoutExtension(OutputPathBox.Text) + ".tmp");

            }
            catch
            {
                
            }
           
            await Task.Delay(3000);

            return null;
        }

        private async void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(AppFullPathBox.Text))
                {
                    MessageBox.Show("ファイルが見つかりませんでした。", "エラー");
                    return;
                }

                if (!File.Exists(InputFilePathBox.Text))
                {
                    MessageBox.Show("ファイルが見つかりませんでした。","エラー");
                    return;
                }

                if (InputFilePathBox.Text == OutputPathBox.Text)
                {
                    MessageBox.Show("入力するファイルと出力するファイルのパスは同じにできません。", "エラー");
                    return;
                }

                if (File.Exists(OutputPathBox.Text))
                {

                    string message = "ファイルが存在していますが、上書きしますか？";

                    string caption = "注意";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                    DialogResult result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }

                running = true;

                String Defaulttitle = this.Text;
                this.Text = Defaulttitle + "|実行中";
                OKButton.Text = "実行中です。";
                QRStringBox.Enabled = false;
                SaveQRButton.Enabled = false;
                OKButton.Enabled = false;
                FileReferenceButton.Enabled = false;
                FileSaveButton.Enabled = false;
                ExeFileReferenceButton.Enabled = false;
                ResetButton.Enabled = false;
                StatusBox.Text = "保存中...";

                await Task.Run(SaveSettings);

                StatusBox.Text = "実行中...";
                
                await Task.Run(Run);

                StatusBox.Text = "保存と実行が完了しました。";
                OKButton.Enabled = true;
                
                if (QRStringBox.Text.Length == 0)
                {
                    FileReferenceButton.Enabled = true;
                }

                ResetButton.Enabled = true;
                SaveQRButton.Enabled = true;
                QRStringBox.Enabled = true;
                FileSaveButton.Enabled = true;
                ExeFileReferenceButton.Enabled = true;
                this.Text = Defaulttitle;
                OKButton.Text = "保存して実行";

                running = false;

                try
                {
                    form.Close();
                }
                catch
                {

                }
            }
            catch (Exception er)
            {
                OKButton.Enabled = true;
                OKButton.Text = "保存して実行";
                //StatusBox.Text = "エラー:\n" + er.ToString();

                if (er.ToString().StartsWith("System.IO.IOException"))
                {
                    MessageBox.Show("ファイルを保存できませんでした。","エラー");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Environment.Exit(1);
        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0:横\n1:縦","Modeの詳細");
        }

        private void info_EditionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0:JE\n1:BE", "Editionの詳細");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo();
            psInfo.FileName = "powershell"; // 実行するファイル
            psInfo.Arguments = "start " + userProfile + "\\mcqr";
            psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
            Process.Start(psInfo);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BlockNameBox.Text = "concrete";
            BlockIDBox.Text = "15";
            BackGroundBlockNameBox.Text = "concrete";
            BackGroundBlockIDBox.Text = "0";
            InputFilePathBox.Text = "";
            OutputPathBox.Text = "";
            xBox.Text = "0";
            yBox.Text = "4";
            zBox.Text = "0";
            modeBox.Text = "0";
            EditionBox.Text = "1";
            
            Properties.Settings setting = Properties.Settings.Default;

            setting.BlockName = "concrete";
            setting.BlockID = "15";
            setting.BackGroundBlockName = "concrete";
            setting.BackGroundBlockID = "0";
            setting.InputFilePath = "";
            setting.OutputPath = "";
            setting.x = "0";
            setting.y = "4";
            setting.z = "0";
            setting.mode = "0";
            setting.edition = "1";
            setting.Save();

        }

        private String FileReferenceDialog(String FilePath = "",String DefaultFileName = "*.txt" ,String Filter = "画像ファイル(*.png;*.jpeg)|*.png;*.jpeg|すべてのファイル(*.*)|*.*")
        {
            String NullPath = "";

            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = DefaultFileName;
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = FilePath;
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = Filter;
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                return ofd.FileName;
            }

            return NullPath;

        }

        private String SaveFileDialog(String Filter = "テキストファイル(*.txt)|*.txt;|すべてのファイル(*.*)|*.*",String DefaultFileName = "output.txt")
        {
            String FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            String NullPath = "";

            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = DefaultFileName;
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = FilePath;
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = Filter;
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 2;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            //既に存在するファイル名を指定したとき警告する
            //デフォルトでTrueなので指定する必要はない
            sfd.OverwritePrompt = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;

            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                return sfd.FileName;
            }

            return NullPath;

        }

        private void FileReferenceButton_Click(object sender, EventArgs e)
        {
            InputFilePathBox.Text = FileReferenceDialog(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "input.png");
        }

        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            OutputPathBox.Text = SaveFileDialog();
        }

        private void ExeFileReferenceButton_Click(object sender, EventArgs e)
        {
            AppFullPathBox.Text = FileReferenceDialog(Environment.CurrentDirectory, "minecraft_qr_generator.exe", "実行ファイル(*.exe;)|*.exe;|すべてのファイル(*.*)|*.*");
        }

        private void SaveQRButton_Click(object sender, EventArgs e)
        {
            InputFilePathBox.Text = SaveFileDialog("画像ファイル(*.png)|*.png;|すべてのファイル(*.*)|*.*","input.png");
            
            if (QRStringBox.Text.Length !=0)
            {
                try
                {
                    var writer = new ZXing.BarcodeWriter();
                    //バーコードの種類
                    writer.Format = ZXing.BarcodeFormat.QR_CODE;
                    //サイズ
                    writer.Options.Height = 200;
                    writer.Options.Width = 200;
                    //マージン
                    writer.Options.Margin = 1;
                    //文字コード
                    writer.Options.Hints.Add(ZXing.EncodeHintType.CHARACTER_SET, "UTF-8");
                    //エラー訂正レベル
                    writer.Options.Hints.Add(ZXing.EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.L);
                    //作成
                    Bitmap image = writer.Write(QRStringBox.Text);
                    image.Save(InputFilePathBox.Text, ImageFormat.Png);
                }
                catch
                {

                }

            }

        }

        private void QRStringBox_TextChanged(object sender, EventArgs e)
        {
            
            if(QRStringBox.TextLength != 0)
            {
                InputFilePathBox.Text = "";
                InputFilePathBox.Enabled = false;
                FileReferenceButton.Enabled = false;
                
                SaveQRButton.Enabled = true;
            }
            else
            {
                InputFilePathBox.Enabled = true;
                FileReferenceButton.Enabled = true;
                
                SaveQRButton.Enabled = false;
            }
        }

        private void AppExit(object sender, FormClosingEventArgs e)
        {
            if (running == true)
            {
                form.Text = "確認";
                // フォームをダイアログボックスとして表示
                DialogResult dialogResult = form.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void InputFilePathBox_TextChanged(object sender, EventArgs e)
        {
            if(InputFilePathBox.Text.Length != 0)
            {
                QRStringBox.Enabled = false;
                SaveQRButton.Enabled = false;
            }
            else
            {
                QRStringBox.Enabled = true;
            }
        }
    }
}
