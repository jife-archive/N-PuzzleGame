using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nPuzzle
{
    class tile : Button
    {

        private puzzle owner;

        public tile(puzzle p)
        {
            this.owner = p;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // tile
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.UseVisualStyleBackColor = false;
            this.ResumeLayout(false);

        }
    }
}
