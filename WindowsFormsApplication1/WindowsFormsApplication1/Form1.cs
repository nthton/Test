using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] drives = Directory.GetLogicalDrives(); //Lấy tất cả ổ đĩa và lưu vào mảng drives
            for (int i = 0; i < drives.Length; i++) //Thêm các ổ đĩa vào TreeView đồng thời tạo các nút con "giả" (*) cho nó
            {
                TreeNode tn;
                tn = new TreeNode(drives[i]);
                treeView1.Nodes.Add(tn); // Ổ đĩa
                tn.Nodes.Add(new TreeNode("*")); // Nút con "giả"
            }
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
                TreeNode tn = new TreeNode(Path.GetFileName(dirName));
                e.Node.Nodes.Add(tn);
                String[] subdirs;
                try
                {
                    subdirs = Directory.GetDirectories(dirs[i]); // kiểm tra xem thư mục mới vừa thêm có thư mục con hay không. Nếu có thì thêm một nút con "giả" vào.
                    if (subdirs.Length > 0)
                        tn.Nodes.Add("temp");
                }
                catch
                { goto err; }

            }
        err:
            Form1.ActiveForm.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            Form1.ActiveForm.Text = e.Node.FullPath;
        }



    }
}
