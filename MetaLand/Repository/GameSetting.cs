using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaLand.Repository
{
    public class GameSetting
    {
        public static int AreaWidth { get; set; }
        public static int AreaHeight { get; set; }
        public int AreaId { get; set; }
        public int AreaOwnerId { get; set; }
        public string Name { get; set; }
        public void SetArea()
        {
            //buttonlist[1]. = 1;
            //int buttonIndex = 0;

            /*for (int row = 0; row < AreaHeight; row++)
            {
                for (int column = 0; column < AreaWidth; column++)
                {
                    if (buttonIndex >= buttons.Count) break;

                    buttons[buttonIndex].Visible = true;
                    buttonIndex++;

                    if (buttonIndex % 5 == 0) break;
                }
            }*/
        }
    }
}
