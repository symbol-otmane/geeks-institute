using System;

public class Sphere : IComparable<Sphere>
{
    private double _radius;

    public Sphere(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive.");
        
        _radius = radius;
    }

    public static Sphere FromDiameter(double diameter)
    {
        if (diameter <= 0)
            throw new ArgumentException("Diameter must be positive.");

        return new Sphere(diameter / 2);
    }

    public double Radius => _radius;

    public double Diameter => _radius * 2;

    public double Volume => (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);

    public double SurfaceArea => 4 * Math.PI * Math.Pow(_radius, 2);

    public override string ToString()
    {
        return $"Sphere → Radius: {Radius:F2}, Diameter: {Diameter:F2}, Volume: {Volume:F2}, Surface Area: {SurfaceArea:F2}";
    }

    public static Sphere operator +(Sphere a, Sphere b)
    {
        return new Sphere(a.Radius + b.Radius);
    }

    public static bool operator >(Sphere a, Sphere b)
    {
        return a.Volume > b.Volume;
    }

    public static bool operator <(Sphere a, Sphere b)
    {
        return a.Volume < b.Volume;
    }

    public static bool operator ==(Sphere a, Sphere b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.Radius == b.Radius;
    }

    public static bool operator !=(Sphere a, Sphere b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Sphere other)
            return other.Radius == this.Radius;

        return false;
    }

    public override int GetHashCode()
    {
        return Radius.GetHashCode();
    }

    public int CompareTo(Sphere other)
    {
        return this.Radius.CompareTo(other.Radius);
    }
}
