
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DBEntity
{

using System;
    using System.Collections.Generic;
    
public partial class CauHoi
{

    public int ID { get; set; }

    public string TieuDe { get; set; }

    public string PhuongAnA { get; set; }

    public string PhuongAnB { get; set; }

    public string PhuongAnC { get; set; }

    public string PhuongAnD { get; set; }

    public string DapAn { get; set; }

    public Nullable<int> IDNghe { get; set; }

    public Nullable<int> IDDoc { get; set; }

    public Nullable<int> IDDeThi { get; set; }

    public Nullable<int> IDChuDe { get; set; }



    public virtual ChuDe ChuDe { get; set; }

    public virtual DeThi DeThi { get; set; }

    public virtual Doc Doc { get; set; }

    public virtual Nghe Nghe { get; set; }

}

}
