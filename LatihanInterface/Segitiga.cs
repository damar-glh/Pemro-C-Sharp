class Segitiga : BangunDatar , IluasBangunDatar{ 
    private double alas;
    private double tinggi;
    public Segitiga(double alas, double tinggi){
        this.alas = alas;
        this.tinggi = tinggi;
    }
    public override double HitungLuas(){ // override menandakan polymorphism
        return 0.5 * alas * tinggi;
    }
}