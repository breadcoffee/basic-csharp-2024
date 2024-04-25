using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafePOS
{
    class ORDER
    {
        // 메뉴 개수
        private int americanoHotCount = 1, latteHotCount = 1, vanilaLatteHotCount = 1, mochaHotCount = 1, einspannerHotCount = 1, cappuccinoHotCount = 1,
                    americanoIceCount = 1, latteIceCount = 1, vanilaLatteIceCount = 1, mochaIceCount = 1, einspannerIceCount = 1, espressoCount = 1;
        
        // 메뉴 총금액
        private int americanoHotPrice = 0, latteHotPrice = 0, vanilaLatteHotPrice = 0, mochaHotPrice = 0, einspannerHotPrice = 0, cappuccinoHotPrice = 0,
                    americanoIcePrice = 0, latteIcePrice = 0, vanilaLatteIcePrice = 0, mochaIcePrice = 0, einspannerIcePrice = 0, espressoPrice = 0;

        //총 금액, 총 커피잔, 총 디저트수 자동 구형 프로퍼티
        public int sumCount
        {
            get; set;
        }
        public int sumCash
        {
            get; set;
        }


        #region "메뉴 카운트 프로퍼티"
        public int AmericanoHotCount
        {
            get { return americanoHotCount; }
            set { americanoHotCount = value; }
        }
        public int AmericanoIceCount
        {
            get { return americanoIceCount; }
            set { americanoIceCount = value; }
        }
        public int EspressoCount
        {
            get { return espressoCount; }
            set { espressoCount = value; }
        }
        public int LatteHotCount
        {
            get { return latteHotCount; }
            set { latteHotCount = value; }
        }
        public int LatteIceCount
        {
            get { return latteIceCount; }
            set { latteIceCount = value; }
        }
        public int CappuccinoHotCount
        {
            get { return cappuccinoHotCount; }
            set { cappuccinoHotCount = value; }
        }

        public int VanilaLatteHotCount
        {
            get { return vanilaLatteHotCount; }
            set { vanilaLatteHotCount = value; }
        }
        public int VanilaLatteIceCount
        {
            set { vanilaLatteIceCount = value; }
            get { return vanilaLatteIceCount; }
        }
        public int MochaHotCount
        {
            get { return mochaHotCount; }
            set { mochaHotCount = value; }
        }
        public int MochaIceCount
        {
            get { return mochaIceCount; }
            set { mochaIceCount = value; }
        }
        public int EinspannerHotCount
        {
            get { return einspannerHotCount; }
            set { einspannerHotCount = value; }
        }
        public int EinspannerIceCount
        {
            get { return einspannerIceCount; }
            set { einspannerIceCount = value; }
        }
        #endregion

        #region "메뉴 금액 프로퍼티"
        public int americanoHotSum
        {
            get { return americanoHotPrice; }
            set { americanoHotPrice = value; }
        }
        public int americanoIceSum
        {
            get { return americanoIcePrice; }
            set { americanoIcePrice = value; }
        }
        public int espressoSum
        {
            get { return espressoPrice; }
            set { espressoPrice = value; }
        }
        public int latteHotSum
        {
            get { return latteHotPrice; }
            set { latteHotPrice = value; }
        }
        public int latteIceSum
        {
            get { return latteIcePrice; }
            set { latteIcePrice = value; }
        }
        public int cappuccinoHotSum
        {
            get { return cappuccinoHotPrice; }
            set { cappuccinoHotPrice = value; }
        }
        public int vanilaLatteHotSum
        {
            get { return vanilaLatteHotPrice; }
            set { vanilaLatteHotPrice = value; }
        }
        public int vanilaLatteIceSum
        {
            get { return vanilaLatteIcePrice; }
            set { vanilaLatteIcePrice = value; }
        }
        public int mochaHotSum
        {
            get { return mochaHotPrice; }
            set { mochaHotPrice = value; }
        }
        public int mochaIceSum
        {
            get { return mochaIcePrice; }
            set { mochaIcePrice = value; }
        }
        public int einspannerHotSum
        {
            get { return einspannerHotPrice; }
            set { einspannerHotPrice = value; }
        }
        public int einspannerIceSum
        {
            get { return einspannerIcePrice; }
            set { einspannerIcePrice = value; }
        }
        #endregion

        #region "메뉴 총금액을 계산해서 반환해주는 메소드"
        public int AmericanoHotSum()
        {
            americanoHotSum = AmericanoHotCount * 1500;
            return americanoHotSum;
        }
        public int AmericanoIceSum()
        {
            americanoIceSum = AmericanoIceCount * 2000;
            return americanoIceSum;
        }
        public int EspressoSum()
        {
            espressoSum = espressoCount * 1500;
            return espressoSum;
        }
        public int LatteHotSum()
        {
            latteHotSum = latteHotCount * 2500;
            return latteHotSum;
        }
        public int LatteIceSum()
        {
            latteIceSum = latteIceCount * 3000;
            return latteIceSum;
        }
        public int CappuccinoHotSum()
        {
            cappuccinoHotSum = cappuccinoHotCount * 2500;
            return cappuccinoHotSum;
        }
        public int VanilaLatteHotSum()
        {
            vanilaLatteHotSum = vanilaLatteHotCount * 3000;
            return vanilaLatteHotSum;
        }
        public int VanilaLatteIceSum()
        {
            vanilaLatteIceSum = vanilaLatteIceCount * 3500;
            return vanilaLatteIceSum;
        }
        public int MochaHotSum()
        {
            mochaHotSum = mochaHotCount * 3000;
            return mochaHotSum;
        }
        public int MochaIceSum()
        {
            mochaIceSum = mochaIceCount * 3500;
            return mochaIceSum;
        }
        public int EinspannerHotSum()
        {
            einspannerHotSum = einspannerHotCount * 4500;
            return einspannerHotSum;
        }
        public int EinspannerIceSum()
        {
            einspannerIceSum = einspannerIceCount * 5000;
            return einspannerIceSum;
        }
        #endregion


        public int SumCount()
        {
            sumCount = AmericanoHotCount + AmericanoIceCount + LatteHotCount + LatteIceCount + EspressoCount + CappuccinoHotCount + VanilaLatteHotCount + VanilaLatteIceCount+ MochaHotCount + MochaIceCount + EinspannerHotCount + EinspannerIceCount;
            return (sumCount-12);
        }
        public int SumCash()
        {
            sumCash = americanoHotSum + americanoIceSum + latteHotSum + latteIceSum + espressoSum + cappuccinoHotSum + vanilaLatteHotSum + vanilaLatteIceSum + mochaHotSum + mochaIceSum + einspannerHotSum + einspannerIceSum;
            return sumCash;
        }
    }
}
