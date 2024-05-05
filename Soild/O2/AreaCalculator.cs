namespace Soild.O2
{
    public class AreaCalculator
    {
        
        
            public double TotalArea(object[] arrObjects)
            {
                double area = 0;
                foreach (var obj in arrObjects)
                {
                    if (obj is Rectangle)
                    {
                        var objRectangle = (Rectangle)obj;
                        area += objRectangle.Height * objRectangle.Width;
                    }
                    else
                    {
                        var objCircle = (Circle)obj;
                        area += objCircle.Radius * objCircle.Radius * Math.PI;
                    }
                }
                return area;
            }
        }
    
}
