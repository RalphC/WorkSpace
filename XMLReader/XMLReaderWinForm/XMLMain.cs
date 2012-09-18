using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace XMLReaderWinForm
{
    public partial class XMLReaderMainForm : Form
    {
        XmlDocument myXMLDoc;

        public XMLReaderMainForm()
        {
            InitializeComponent();
        }

        private void XMLTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void XMLTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            using (FileStream myFS = new FileStream(FileList[0], FileMode.Open))
            {
                using (StreamReader mySR = new StreamReader(myFS))
                {
                    XMLTextBox.Text = mySR.ReadToEnd();
                }
            }
            CreateTreeview(FileList[0]);
        }

        private void CreateTreeview(string FileName)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                XMLTreeView.Nodes.Clear();

                myXMLDoc = new XmlDocument();
                myXMLDoc.Load(FileName);
                XMLTreeView.Nodes.Add(new TreeNode(myXMLDoc.DocumentElement.Name));

                addTreeNode(myXMLDoc.DocumentElement, (TreeNode)XMLTreeView.Nodes[0]);

                XMLTreeView.ExpandAll();
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void addTreeNode(XmlNode XMLNode, TreeNode TreeNode)
        {
            XmlNode myXMLNode;
            TreeNode myTreeNode;
            XmlNodeList myXMLNodeList;
            if (XMLNode.HasChildNodes)
            {
                myXMLNodeList = XMLNode.ChildNodes;
                for (int i = 0; i < myXMLNodeList.Count; i++)
                {
                    myXMLNode = XMLNode.ChildNodes[i];
                    TreeNode.Nodes.Add(new TreeNode(myXMLNode.Name));
                    myTreeNode = TreeNode.Nodes[i];
                    addTreeNode(myXMLNode, myTreeNode);
                }
            }
            else TreeNode.Text = XMLNode.OuterXml.Trim();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog myDialog = new OpenFileDialog();
            if (DialogResult.OK == myDialog.ShowDialog())
            {
                CreateTreeview(myDialog.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XMLTextBox.Clear();
            XMLTreeView.Nodes.Clear();
            System.GC.Collect();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("XMLReader V1.0 beta", "About XMLReader", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void XMLTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text.ToString());
        }

    }
}
