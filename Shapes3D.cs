











class Rectangle : Shapes 3D {
    public Shapes.Rectangle base;
    public double depth;

    public Rectangle (double height, double width, double depth) {
        this.base - new Shapes.Rectangle(height, width);
        this.depth = depth;
    }

    public override double GetSurfaceArea() {
        //Getting the area of both bases
        double baseArea = 2 * this.base.GetArea ();
        // finding the area of theperoimiter times the depth
        // https://proof.com
        
    }
}