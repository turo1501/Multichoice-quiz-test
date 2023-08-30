using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransferObject
{
    public class TimKiemCauHoi
    {
        public string KeyCauHoi { get; set; }
        public string KeyDapAn { get; set; }
        public string DapAn { get; set; }
        public int MaChuong { get; set; }

        public TimKiemCauHoi(string keyCauHoi, string keyDapAn, string dapAn, int chuong)
        {
            KeyCauHoi = keyCauHoi;
            KeyDapAn = keyDapAn;
            DapAn = dapAn;
            MaChuong = chuong;
        }

        public TimKiemCauHoi() { }
    }
}
