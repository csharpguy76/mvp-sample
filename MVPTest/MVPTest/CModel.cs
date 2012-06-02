using System;

namespace MVPTest
{
	public class CModel:ICircleModel
	{
		public CModel ()
		{
		}
		
		public double getArea(double radius)
		{
			return Math.PI * radius *radius;
		}
	}
}

