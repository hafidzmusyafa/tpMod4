using System;
using System.Collections.Generic;

public class KodePos
{
    public string Kode { get; set; }
    public string Kelurahan { get; set; }
}
public class Doormachine
{
    public enum State { terbuka, tekunci }

    private State stateAwal;

    public void Open()
    {
        stateAwal = State.terbuka;
        Console.WriteLine("Pintu terbuka");
    }
    public void Close()
    {
        stateAwal = State.tekunci;
        Console.WriteLine("Pintu tertutup");
    }
    public void Lock()
    {
        stateAwal = State.tekunci;
        Console.WriteLine("Pintu terkunci");
    }

    class MainClass
    {
        static void Main()
        {
            List<KodePos> isiKodePos = new List<KodePos>
                {
                    new KodePos { Kelurahan = "Batununggal", Kode = "40266" },
                    new KodePos { Kelurahan = "Kujangsari", Kode = "40287" },
                    new KodePos { Kelurahan = "Mengger", Kode = "40267" },
                    new KodePos { Kelurahan = "Wates", Kode = "40256" },
                    new KodePos { Kelurahan = "Cijaura", Kode = "40287" },
                    new KodePos { Kelurahan = "Jatisari", Kode = "40286" },
                    new KodePos { Kelurahan = "Margasari", Kode = "40286" },
                    new KodePos { Kelurahan = "Sekejati", Kode = "40286" },
                    new KodePos { Kelurahan = "Kebonwaru", Kode = "40272" },
                    new KodePos { Kelurahan = "Maleer", Kode = "40274" },
                    new KodePos { Kelurahan = "Samoja", Kode = "40273" }
                };

            foreach (var data in isiKodePos)
            {
                Console.WriteLine("Kelurahan: " + data.Kelurahan, "Kode Pos: " + data.Kode);
            }

            Doormachine pintu = new Doormachine();
            pintu.Open();
            pintu.Close();
            pintu.Lock();
            pintu.Open();
        }
    }
}