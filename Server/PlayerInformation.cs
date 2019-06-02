using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class PlayerInformation
    {
        public string Name { get; set; } // tên người chơi
        public int SoCauDung { get; set; } // số câu trả lời đúng
        public int SoTienNhanDuoc { get; set; } // số tiền nhận được 
        public int CacQuyenTroGiup { get; set; } // Các quyền trợ giúp còn lại
    }
}
