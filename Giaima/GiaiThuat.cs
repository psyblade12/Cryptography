using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaima
{
    class GiaiThuat
    {
        public static int binhphuonglientiep(int a, int k, int m)
        {
            int p;
            if (k == 0)
            {
                return 1;
            }
            else
            {
                p = binhphuonglientiep(a, k / 2, m);
                if (k % 2 == 0)
                    return (p * p) % m;
                else
                    return (p * p * a) % m;
            }
        }
        public static int MaHoaRSA(int p, int q, int M)
        {
            Khoa khoacongkhai = new Khoa();
            Khoa khoabimat = new Khoa();
            int N = p * q;
            int n = (p - 1) * (q - 1);
            int e = 0;
            for (int i = 2; i < n; i++)
            {
                SoKetQua kq = GiaiThuat.TinhEuclid(i, n);
                if (kq.Ucln == 1)
                {
                        e = i;
                        break;
                }
                else
                {
                    continue;
                }
            }
            int d = GiaiThuat.TinhEuclid(n, e).Nghichdao;
            khoacongkhai.So1 = e;
            khoacongkhai.So2 = N;
            khoabimat.So1 = d;
            khoabimat.So2 = N;
            int C = binhphuonglientiep(M, e, N);
            return C;
        }
        public static int MaHoaBaoMatRSA(int e, int N, int M)
        {
            int C = binhphuonglientiep(M, e, N);
            return C;
        }
        public static int GiaiMaBaoMatRSA(int d, int N, int C)
        {
            int Mngang = binhphuonglientiep(C, d, N);
            return Mngang;
        }
        public static int MaHoaChungThucRSA(int d, int N, int M)
        {
            int C = binhphuonglientiep(M, d, N);
            return C;
        }
        public static int GiaiMaChungThucRSA(int e, int N, int C)
        {
            int Mngang = binhphuonglientiep(C, e, N);
            return Mngang;
        }
        public static int GiaiMaRSA(int p, int q, int C)
        {
            Khoa khoacongkhai = new Khoa();
            Khoa khoabimat = new Khoa();
            int N = p * q;
            int n = (p - 1) * (q - 1);
            int e = 0;
            for (int i = 2; i < n; i++)
            {
                SoKetQua kq = GiaiThuat.TinhEuclid(i, n);
                if (kq.Ucln == 1)
                {
                        e = i;
                        break;
                }
            }
            int d = GiaiThuat.TinhEuclid(n, e).Nghichdao;
            khoacongkhai.So1 = e;
            khoacongkhai.So2 = N;
            khoabimat.So1 = d;
            khoabimat.So2 = N;
            int Mngang = binhphuonglientiep(C, d, N);
            return Mngang;
        }

        public static void ChuyenSoLonThanhCacSonho(int somuonchuyen, ref List<int> mangso)
        {
            if (somuonchuyen <= 200)
            {
                mangso.Add(somuonchuyen);
            }
            else
            {
                mangso.Add(200);
                int soconlai = somuonchuyen - 200;
                if (soconlai > 200)
                {
                    ChuyenSoLonThanhCacSonho(soconlai, ref mangso);
                }
                else
                {
                    mangso.Add(soconlai);
                }
            }
        }

        public static SoKetQua TinhEuclid(int a, int b)
        {
            SoKetQua kq = new SoKetQua();
            int A1 = 1;
            int A2 = 0;
            int A3 = a;
            int B1 = 0;
            int B2 = 1;
            int B3 = b;
            int Q = 0;
            int R1 = 0;
            int R2 = 0;
            int R3 = 0;
            while (B3 != 0 && B3 != 1)
            {
                Q = A3 / B3;
                R1 = A1 - (Q * B1);
                R2 = A2 - (Q * B2);
                R3 = A3 - (Q * B3);
                A1 = B1;
                A2 = B2;
                A3 = B3;
                B1 = R1;
                B2 = R2;
                B3 = R3;

            }
            if (B3 == 0)
            {
                kq.Ucln = A3;
                kq.Nghichdao = 0;
                return kq;
            }
            else
            {
                kq.Ucln = 1;
                if (B2 < 0)
                {
                    kq.Nghichdao = B2 + a;
                }
                else
                {
                    kq.Nghichdao = B2;
                }
                return kq;
            }

        }
    }
}
