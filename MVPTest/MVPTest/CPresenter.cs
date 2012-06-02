using System;

namespace MVPTest
{
	public class CPresenter
	{
		IView mview;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
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

