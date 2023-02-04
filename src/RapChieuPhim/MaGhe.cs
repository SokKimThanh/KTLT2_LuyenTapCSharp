using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTLT2_TAODOITUONG.src.RapChieuPhim
{
    class MaGhe
    {
        string hangGhe;
        int soGhe;
        public MaGhe() { }

        public MaGhe(string hangGhe, int soGhe)
        {
            this.hangGhe = hangGhe;
            this.soGhe = soGhe;
        }
        public void AddHangGhe()
        {
            hangGhe = $"{(int)TaoRandom.TaoKiTuChuHoa()}";
        }
        public void AddSoGhe()
        {
            soGhe = (int)TaoRandom.TaoKiTuSo();
        }

        public string ToPrint()
        {
            return $"{hangGhe}/{soGhe}";
        }
    }
}
