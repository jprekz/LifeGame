using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeGame
{
    public partial class Form1 : Form
    {
        LifeGame Game;

        Bitmap canvas;

        int CellSize = 5;

        public Form1()
        {
            InitializeComponent();
            this.LoopToolStripMenuItem.Checked = Settings1.Default.CellsLoop;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ゲームの初期化
            GameInit(120, 100);
            Draw();
        }

        private void GameInit(int x, int y)
        {
            Game = new LifeGame(x, y);
            Game.CellsLoop = this.LoopToolStripMenuItem.Checked;
            // 描画先とするImageオブジェクトを作成する
            canvas = new Bitmap(x * CellSize, y * CellSize);
        }
        
        private void Draw()
        {
            // ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            g.FillRectangle(Brushes.White, 0, 0, CellSize * Game.CellsX, CellSize * Game.CellsY);
            for (var j = 0; j < Game.CellsY; j++)
            {
                for (var i = 0; i < Game.CellsX; i++)
                {
                    if (Game.Cells[i, j] == 1)
                    {
                        g.FillRectangle(Brushes.Black, i * CellSize, j * CellSize, CellSize, CellSize);
                    }
                }
            }
            // Graphicsオブジェクトのリソースを解放する
            g.Dispose();
            // pictureBox1に表示する
            pictureBox1.Image = canvas;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.OnFrame();
            Draw();
        }

        private void ExitXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.CellsLoop = this.LoopToolStripMenuItem.Checked;
            Settings1.Default.CellsLoop = this.LoopToolStripMenuItem.Checked;
        }

        private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                this.PauseToolStripMenuItem.Text = "一時停止";
            }
            else
            {
                this.PauseToolStripMenuItem.Text = "開始";
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                this.PauseToolStripMenuItem.Text = "開始";
            }
            Form_new form_new = new Form_new();
            form_new.ShowDialog();
            if (form_new.NewFlag)
            {
                GameInit((int)form_new.numericUpDown_x.Value, (int)form_new.numericUpDown_y.Value);
                if (form_new.checkBox_rnd.Checked)
                {
                    Game.CellsRndInit(form_new.numericUpDown_rnd.Value);
                }
                Draw();
            }
            form_new.Dispose();
        }

        private void CellSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CellSize form_cell = new Form_CellSize();
            form_cell.ShowDialog();
            if (form_cell.ApplyFlag)
            {
                CellSize = (int)form_cell.numericUpDown1.Value;
                // 描画先とするImageオブジェクトを作成する
                canvas = new Bitmap(Game.CellsX * CellSize, Game.CellsY * CellSize);
                Draw();
            }
            form_cell.Dispose();
        }

        private void OpenOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                this.PauseToolStripMenuItem.Text = "開始";
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (fileOpen(openFileDialog1.FileName) == -1)
                {
                    MessageBox.Show("ファイルの読み込み中にエラーが発生しました", "警告", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                Draw();
            }
        }

        private int fileOpen(string file)
        {
            int x, y;

            //文字コードを取得する
            System.IO.FileStream fs = new System.IO.FileStream(
                file, System.IO.FileMode.Open,
                System.IO.FileAccess.Read);
            byte[] bs = new byte[fs.Length];
            fs.Read(bs, 0, bs.Length);
            fs.Close();
            System.Text.Encoding enc = str.GetCode(bs);
            string stBuffer = enc.GetString(bs);
            stBuffer = stBuffer.Replace("\r", "").Replace("\n", "");

            // カンマ区切りで分割して配列に格納する
            string[] stArrayData = stBuffer.Split(',');
            int num;
            int[] stIntData = new int[stArrayData.Length];;
            for (int i = 0; i <= stArrayData.Length - 1; i++)
            {
                if (int.TryParse(stArrayData[i], out num))
                {
                    stIntData[i] = num;
                }
                else
                {
                    return -1;
                }
            }

            if (stIntData.Length <= 2) { return -1; }
            x = stIntData[0];
            y = stIntData[1];
            if (stIntData.Length != x * y + 2) { return -1; }
            GameInit(x, y);
            Game.CellsMatrixInit(stIntData.Skip(2).ToArray());

            return 0;
        }

        // 以下、マウスでセルを編集する際の処理
        int start = 0;  // 1 = 描画中

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = 1;
            if ((e.X / CellSize >= 0) && (e.X / CellSize < Game.CellsX) && (e.Y / CellSize >= 0) && (e.Y / CellSize < Game.CellsY))
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    Game.Cells[e.X / CellSize, e.Y / CellSize] = 1;
                }
                else if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
                {
                    Game.Cells[e.X / CellSize, e.Y / CellSize] = 0;
                }
            }
            Draw();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            start = 0;
            Draw();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (start == 0) return;
            if ((e.X / CellSize >= 0) && (e.X / CellSize < Game.CellsX) && (e.Y / CellSize >= 0) && (e.Y / CellSize < Game.CellsY))
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    Game.Cells[e.X / CellSize, e.Y / CellSize] = 1;
                }
                else if ((e.Button & MouseButtons.Right) == MouseButtons.Right)
                {
                    Game.Cells[e.X / CellSize, e.Y / CellSize] = 0;
                }
            }
            //Draw(); // 重い
        }
    }
}
