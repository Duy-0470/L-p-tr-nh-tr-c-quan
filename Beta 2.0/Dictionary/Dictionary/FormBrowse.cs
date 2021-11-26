using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class FormBrowse : Form
    {
        public FormBrowse()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void FormBrowse_Load(object sender, EventArgs e)
        {
            if (MainMenu.current_language == "English - Vietnamese")
            {
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVa.txt"))
                {
                    ListViewA.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVb.txt"))
                {
                    ListViewB.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVc.txt"))
                {
                    ListViewC.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVd.txt"))
                {
                    ListViewD.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVe.txt"))
                {
                    ListViewE.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVf.txt"))
                {
                    ListViewF.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVg.txt"))
                {
                    ListViewG.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVh.txt"))
                {
                    ListViewH.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVi.txt"))
                {
                    ListViewI.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVj.txt"))
                {
                    ListViewJ.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVk.txt"))
                {
                    ListViewK.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVl.txt"))
                {
                    ListViewL.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVm.txt"))
                {
                    ListViewM.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVn.txt"))
                {
                    ListViewN.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVo.txt"))
                {
                    ListViewO.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVp.txt"))
                {
                    ListViewP.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVr.txt"))
                {
                    ListViewR.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVs.txt"))
                {
                    ListViewS.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVt.txt"))
                {
                    ListViewT.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVu.txt"))
                {
                    ListViewU.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVv.txt"))
                {
                    ListViewV.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVw.txt"))
                {
                    ListViewW.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVx.txt"))
                {
                    ListViewX.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVy.txt"))
                {
                    ListViewY.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishVietnamese\\list\\EVz.txt"))
                {
                    ListViewZ.Items.Add(line);
                }
            }
            else if (MainMenu.current_language == "English - English")
            {
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEa.txt"))
                {
                    ListViewA.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEb.txt"))
                {
                    ListViewB.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEc.txt"))
                {
                    ListViewC.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEd.txt"))
                {
                    ListViewD.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEe.txt"))
                {
                    ListViewE.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEf.txt"))
                {
                    ListViewF.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEg.txt"))
                {
                    ListViewG.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEh.txt"))
                {
                    ListViewH.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEi.txt"))
                {
                    ListViewI.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEj.txt"))
                {
                    ListViewJ.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEk.txt"))
                {
                    ListViewK.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEl.txt"))
                {
                    ListViewL.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEm.txt"))
                {
                    ListViewM.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEn.txt"))
                {
                    ListViewN.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEo.txt"))
                {
                    ListViewO.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEp.txt"))
                {
                    ListViewP.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEr.txt"))
                {
                    ListViewR.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEs.txt"))
                {
                    ListViewS.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEt.txt"))
                {
                    ListViewT.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEu.txt"))
                {
                    ListViewU.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEv.txt"))
                {
                    ListViewV.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEw.txt"))
                {
                    ListViewW.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEx.txt"))
                {
                    ListViewX.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEy.txt"))
                {
                    ListViewY.Items.Add(line);
                }
                foreach (string line in File.ReadAllLines(Database.DatabaseHandle.DataDirectories + "words\\EnglishEnglish\\list\\EEz.txt"))
                {
                    ListViewZ.Items.Add(line);
                }
            }
        }

        private void FormBrowse_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.instance.Show();
        }

        private void FormBrowse_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void ListViewA_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewA.SelectedItems[0].Text;
            Close();
        }

        private void ListViewB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewB.SelectedItems[0].Text;
            Close();
        }

        private void ListViewC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewC.SelectedItems[0].Text;
            Close();
        }

        private void ListViewD_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewD.SelectedItems[0].Text;
            Close();
        }

        private void ListViewE_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewE.SelectedItems[0].Text;
            Close();
        }

        private void ListViewF_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewF.SelectedItems[0].Text;
            Close();
        }

        private void ListViewG_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewG.SelectedItems[0].Text;
            Close();
        }

        private void ListViewH_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewH.SelectedItems[0].Text;
            Close();
        }

        private void ListViewI_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewI.SelectedItems[0].Text;
            Close();
        }

        private void ListViewJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewJ.SelectedItems[0].Text;
            Close();
        }

        private void ListViewK_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewK.SelectedItems[0].Text;
            Close();
        }

        private void ListViewL_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewL.SelectedItems[0].Text;
            Close();
        }

        private void ListViewM_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewM.SelectedItems[0].Text;
            Close();
        }

        private void ListViewN_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewN.SelectedItems[0].Text;
            Close();
        }

        private void ListViewO_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewO.SelectedItems[0].Text;
            Close();
        }

        private void ListViewP_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewP.SelectedItems[0].Text;
            Close();
        }

        private void ListViewQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewQ.SelectedItems[0].Text;
            Close();
        }

        private void ListViewR_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewR.SelectedItems[0].Text;
            Close();
        }

        private void ListViewS_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewS.SelectedItems[0].Text;
            Close();
        }

        private void ListViewT_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewT.SelectedItems[0].Text;
            Close();
        }

        private void ListViewU_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewU.SelectedItems[0].Text;
            Close();
        }

        private void ListViewV_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewV.SelectedItems[0].Text;
            Close();
        }

        private void ListViewW_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewW.SelectedItems[0].Text;
            Close();
        }

        private void ListViewX_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewX.SelectedItems[0].Text;
            Close();
        }

        private void ListViewY_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewY.SelectedItems[0].Text;
            Close();
        }

        private void ListViewZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSearch.search = ListViewZ.SelectedItems[0].Text;
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "recentToolStripMenuItem_Click"))
            {
                FormRecent fr = new FormRecent();
                fr.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "toolStripMenuItem1_Click"))
            {
                FormFavorites ff = new FormFavorites();
                ff.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ToolStripMenuItemFavorites_Click"))
            {
                FormGames fg = new FormGames();
                fg.Show();
            }
            else if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewA_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewB_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewC_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewD_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewE_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewF_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewG_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewH_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewI_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewJ_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewK_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewL_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewM_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewN_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewO_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewP_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewQ_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewR_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewS_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewT_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewU_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewV_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewW_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewX_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewY_SelectedIndexChanged")
                || new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "ListViewZ_SelectedIndexChanged"))
            {
                WordMeaning wm = new WordMeaning();
                wm.Show();
            }
            else
            {
                MainMenu.instance.Show();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wordGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
