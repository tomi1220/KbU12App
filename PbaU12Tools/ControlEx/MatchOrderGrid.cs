using PbaU12Tools.Bracket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PbaU12Tools.ControlEx
{
    public partial class MatchOrderGrid : UserControl
    {
        #region 定数
        #endregion

        #region フィールド
        private BracketGenData _genData;
        #endregion

        #region コンストラクタ
        public MatchOrderGrid()
        {
            InitializeComponent();
        }
        #endregion

        #region プロパティ
        #endregion

        #region メソッド
        public void GenerateGrid(BracketGenData GenData)
        {
            _genData = GenData;


        }
        #endregion

        #region ローカル・メソッド
        private void drawGrid()
        {

        }
        #endregion
    }
}
