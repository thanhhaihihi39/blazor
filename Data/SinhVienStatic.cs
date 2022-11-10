namespace BlazorNhiber1.Data
{
    public class SinhVienStatic
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Sex { get; set; }
        public virtual int Age { get; set; }
        public virtual float DiemToan { get; set; }
        public virtual float DiemAnh { get; set; }
        public virtual float DiemVan { get; set; }
        public virtual float DiemTrungBinh { get; set; }
        public virtual string HocLuc { get; set; }
        public virtual int CountToanGioi { get; set; }
        public virtual int CountToanKha { get; set; }
        public virtual int CountToanTrungBinh { get; set; }
        public virtual int CountVanGioi { get; set; }
        public virtual int CountVanKha { get; set; }
        public virtual int CountVanTrungBinh { get; set; }
        public virtual int CountAnhGioi { get; set; }
        public virtual int CountAnhKha { get; set; }
        public virtual int CountAnhTrungBinh { get; set; }

        public virtual int CountAll { get; set; }
    }

}
