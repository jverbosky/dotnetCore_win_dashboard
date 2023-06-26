using System;


namespace dotnetCore_win_dashboard_Models
{
    public class WindowDetails
    {
        public string Process { get; set; }
        public string Argument { get; set; }
        public string WindowTitle { get; set; }
        public WindowPosition WindowPosition { get; set; }
    }    

    public class WindowPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int CX { get; set; }
        public int CY { get; set; }
    }

}