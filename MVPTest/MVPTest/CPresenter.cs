using System;

namespace MVPTest
{
	public class CPresenter
	{
		IView mview;
		public CPresenter (IView view)
		{
			mview = view;
		}
		
		public string CalculateCircleArea()
		{
			CModel model = new CModel();
			mview.ResultText  = model.getArea(double.Parse(mview.RadiusText)).ToString();
			return mview.ResultText.ToString();
		}
		
	}
}

