using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string disk in Directory.GetLogicalDrives())
            {
                DriveInfo dI = new DriveInfo(disk);
                int driveImage;
                switch (dI.DriveType)
                {
                    case DriveType.CDRom:
                        driveImage = 1;
                        break;
                    case DriveType.Network:
                        driveImage = 4;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }
                TreeNode tn = new TreeNode(disk, driveImage, driveImage);
                tn.Tag = disk;
                Cay.Nodes.Add(tn);
                if (dI.IsReady == true)
                    tn.Nodes.Add(new TreeNode("...")); // thêm nút con giả vào

            }
            //TreeNode tn = new TreeNode("A");
            //Cay.Nodes.Add(tn);


        }
        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            Form1.ActiveForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (e.Node.Nodes.Count != 0)
                e.Node.Nodes.RemoveAt(0); //Xóa nút con "giả"
            String[] dirs;
            try
            {
                dirs = Directory.GetDirectories(e.Node.FullPath); //Lấy danh sách thư mục
                Array.Sort(dirs); //và sắp xếp chúng
            }
            catch (Exception pe) //Bẫy lỗi
            {
                MessageBox.Show(pe.Message, "Error!");
                goto err;
            }
            for (int i = 0; i < dirs.Length; i++) //thêm danh sách thư mục vào nút con đó
            {
                String dirName = dirs[i];
                TreeNode tn = new TreeNode(Path.GetFileName(dirName), 0, 0);
                e.Node.Nodes.Add(tn);
                String[] subdirs;

                try
                {
                    subdirs = Directory.GetDirectories(dirs[i]); // kiểm tra xem thư mục mới vừa thêm có thư mục con hay không. Nếu có thì thêm một nút con "giả" vào.
                    if (subdirs.Length > 0)
                        tn.Nodes.Add("...");
                }
                catch
                {
                }
            }
        err:
            Form1.ActiveForm.Cursor = System.Windows.Forms.Cursors.Default;

        }
        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Clear();

        }
        private static string LayDuongDan(string fullpath)
        {
            char[] arr = { '\\' };
            string path = "";
            string[] nameList = fullpath.Split(arr);
            string nodeName = nameList.GetValue(0).ToString();
            path += nodeName + "\\";
            for (int i = 2; i < nameList.Length; i++)
                path += nameList[i] + "\\";
            return path;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string Path = LayDuongDan(e.Node.FullPath);
            txt1.Text = Path;
            if (Directory.Exists(Path))
            {
                var dirs = Directory.GetDirectories(Path);
                var files = Directory.GetFiles(Path);

                foreach (string dir in dirs)
                {
                    var dirInfo = new DirectoryInfo(dir);
                    var folderItem = new ListViewItem(dirInfo.Name);
                    var folderDatemodified = new ListViewItem.ListViewSubItem(folderItem, dirInfo.LastWriteTime.ToString());
                    var folderType = new ListViewItem.ListViewSubItem(folderItem, "File folder");

                    folderItem.SubItems.Add(folderDatemodified);
                    folderItem.SubItems.Add(folderType);
                    folderItem.ImageIndex = 0;
                    listView1.Items.Add(folderItem);
                }

                foreach (string file in files)
                {
                    var fi = new FileInfo(file);

                    Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(file);
                    imageList.Images.Add(icon);

                    var fileItem = new ListViewItem(fi.Name);
                    decimal fsize = Math.Ceiling((decimal)fi.Length / 1024);
                    string strSize = "";
                    if (fsize / 1024 > 1024)
                    {
                        fsize /= 1024;
                        fsize /= 1024;
                        strSize = Math.Round(fsize, 1).ToString() + "GB";
                    }
                    if (fsize > 1024)
                    {
                        fsize /= 1024;
                        strSize = Math.Round(fsize, 1).ToString() + "MB";
                    }

                    string ftype = "";
                    string[] temp = fi.Name.Split('.');
                    int count = 0;
                    foreach (string z in temp)
                    {
                        count++;
                    }
                    ftype = temp.GetValue(count - 1).ToString();

                    var fileDateModified = new ListViewItem.ListViewSubItem(fileItem, fi.LastWriteTime.ToString());
                    var fileType = new ListViewItem.ListViewSubItem(fileItem, ftype);
                    var fileSize = new ListViewItem.ListViewSubItem(fileItem, strSize);

                    fileItem.SubItems.Add(fileDateModified);
                    fileItem.SubItems.Add(fileType);
                    fileItem.SubItems.Add(fileSize);
                    fileItem.ImageIndex = 3;

                    listView1.Items.Add(fileItem);
                }

            }
            else
                MessageBox.Show(null, "Windows can't open \'" + Path + "\'.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Clear();
            string Path = txt1.Text;
            if (Directory.Exists(Path))
            {
                var dirs = Directory.GetDirectories(Path);
                var files = Directory.GetFiles(Path);

                foreach (string dir in dirs)
                {
                    var dirInfo = new DirectoryInfo(dir);
                    var folderItem = new ListViewItem(dirInfo.Name);
                    var folderDatemodified = new ListViewItem.ListViewSubItem(folderItem, dirInfo.LastWriteTime.ToString());
                    var folderType = new ListViewItem.ListViewSubItem(folderItem, "File folder");

                    folderItem.SubItems.Add(folderDatemodified);
                    folderItem.SubItems.Add(folderType);
                    folderItem.ImageIndex = 0;
                    listView1.Items.Add(folderItem);
                }

                foreach (string file in files)
                {
                    var fi = new FileInfo(file);

                    Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(file);
                    imageList.Images.Add(icon);

                    var fileItem = new ListViewItem(fi.Name);
                    decimal fsize = Math.Ceiling((decimal)fi.Length / 1024);
                    string strSize = "";
                    if (fsize / 1024 > 1024)
                    {
                        fsize /= 1024;
                        fsize /= 1024;
                        strSize = Math.Round(fsize, 1).ToString() + "GB";
                    }
                    if (fsize > 1024)
                    {
                        fsize /= 1024;
                        strSize = Math.Round(fsize, 1).ToString() + "MB";
                    }

                    string ftype = "";
                    string[] temp = fi.Name.Split('.');
                    int count = 0;
                    foreach (string z in temp)
                    {
                        count++;
                    }
                    ftype = temp.GetValue(count - 1).ToString();

                    var fileDateModified = new ListViewItem.ListViewSubItem(fileItem, fi.LastWriteTime.ToString());
                    var fileType = new ListViewItem.ListViewSubItem(fileItem, ftype);
                    var fileSize = new ListViewItem.ListViewSubItem(fileItem, strSize);

                    fileItem.SubItems.Add(fileDateModified);
                    fileItem.SubItems.Add(fileType);
                    fileItem.SubItems.Add(fileSize);
                    fileItem.ImageIndex = 3;

                    listView1.Items.Add(fileItem);
                }

            }
            else
                MessageBox.Show(null, "Windows can't open \'" + Path + "\'.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Cay.Nodes['A'].Expand();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            string temp = "\\" + listView1.SelectedItems[0].Text;
            txt1.Text = LayDuongDan(txt1.Text + temp);
            btnGO_Click(sender, e);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGO.PerformClick();

        }

        
    }

    public class myTreeNode : TreeNode
    {
        public string FilePath;

        public myTreeNode(string fp)
        {
            FilePath = fp;
            this.Text = fp.Substring(fp.LastIndexOf("\\"));
        }

        public static void Xuat(string str)
        {
            
        }
    }
}