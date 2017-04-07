using System;
using WFA_PH_CurveDemo;
namespace Example6_3
{
    public class ChartFunctions
    {
        public ChartFunctions()
        {
        }

        public void Line3D(DataSeries ds, ChartStyle cs)
        {
            cs.XMin = -1f;
            cs.XMax = 1f;
            cs.YMin = -1f;
            cs.YMax = 1f;
            cs.ZMin = 0;
            cs.ZMax = 30;
            cs.XTick = 0.5f;
            cs.YTick = 0.5f;
            cs.ZTick = 5;

            ds.XDataMin = cs.XMin;
            ds.YDataMin = cs.YMin;
            ds.XSpacing = 0.3f;
            ds.YSpacing = 0.3f;
            ds.XNumber = Convert.ToInt16((cs.XMax - cs.XMin) / ds.XSpacing) + 1;
            ds.YNumber = Convert.ToInt16((cs.YMax - cs.YMin) / ds.YSpacing) + 1;
            ds.PointList.Clear();

            for (int i = 0; i < 300; i++)
            {
                float t = 0.1f * i;
                float x = (float)Math.Exp(-t / 30) *
                    (float)Math.Cos(t);
                float y = (float)Math.Exp(-t / 30) *
                    (float)Math.Sin(t);
                float z = t;
                ds.AddPoint(new Point3(x, y, z, 1));
            }
        }

        public void Peak3D(DataSeries ds, ChartStyle cs)
        {


            /*

                   cs.XMin = -1;
                   cs.XMax = 1;
                   cs.YMin = -1;
                   cs.YMax = 1;
                   cs.ZMin = -1;
                   cs.ZMax = 1;
                   cs.XTick = 1;
                   cs.YTick = 1;
                   cs.ZTick = 1;

                   //cs.XMin = -1;
                   //cs.XMax = 1;
                   //cs.YMin = -1;
                   //cs.YMax = 1;
                   //cs.ZMin = -1;
                   //cs.ZMax = 1;
                   //cs.XTick = 1;
                   //cs.YTick = 1;
                   //cs.ZTick = 1;

                   ds.XDataMin = cs.XMin;
                   ds.YDataMin = cs.YMin;
            ds.XSpacing = 1;// 0.3f;
            ds.YSpacing = 1;// 0.3f;
                   ds.XNumber = Convert.ToInt16((cs.XMax - cs.XMin) / ds.XSpacing) + 1;
                   ds.YNumber = Convert.ToInt16((cs.YMax - cs.YMin) / ds.YSpacing) + 1;

                   Point3[,] pts = new Point3[ds.XNumber, ds.YNumber];
                   for (int i = 0; i < ds.XNumber; i++)
                   {
                       for (int j = 0; j < ds.YNumber; j++)
                       {
                           float x = ds.XDataMin + i * ds.XSpacing;
                           float y = ds.YDataMin + j * ds.YSpacing;
                          /*
                             double zz = 3 * Math.Pow((1 - x), 2) * Math.Exp(-x * x -
                                (y + 1) * (y + 1)) - 10 * (0.2 * x - Math.Pow(x, 3) -
                                Math.Pow(y, 5)) * Math.Exp(-x * x - y * y) -
                                1 / 3 * Math.Exp(-(x + 1) * (x + 1) - y * y);
                            */ /* 
                           double zz = Math.Pow(x, 2) + Math.Pow(y, 2);
                      float z = (float)zz;


                           pts[i, j] = new Point3(x, y, z, 1);
                       }
                   }

            //==========================Contour demo code added====================//
            /* 

             int[,] X = new int[3, 3];
             int[,] Y = new int[3, 3];
             int[,] Z = new int[3, 3];

             X[0, 0] = -1;
             X[1, 0] = -1;
             X[2, 0] = -1;

             X[0, 1] = 0;
             X[1, 1] = 0;
             X[2, 1] = 0;

             X[0, 2] = 1;
             X[1, 2] = 1;
             X[2, 2] = 1;


             Y[0, 0] = -1;
             Y[1, 0] = 0;
             Y[2, 0] = 1;

             Y[0, 1] = -1;
             Y[1, 1] = 0;
             Y[2, 1] = 1;

             Y[0, 2] = -1;
             Y[1, 2] = 0;
             Y[2, 2] = 1;



             Z[0, 0] = 2;
             Z[1, 0] = 1;
             Z[2, 0] = 2;

             Z[0, 1] = 1;
             Z[1, 1] = 0;
             Z[2, 1] = 1;

             Z[0, 2] = 2;
             Z[1, 2] = 1;
             Z[2, 2] = 2;

             Point3[,] pts = new Point3[3, 3];

             for (int i = 0; i <3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     //pts[i, j].X = X[i, j];
                     //pts[i, j].Y = Y[i, j];
                     //pts[i, j].Z = Z[i, j];
                     pts[i, j] = new Point3(X[i,j], Y[i,j], Z[i,j], 1);

                 }
             }

             //=====================End of the contour demo code==================//

    */

            //==First calling the data in WFA_PH_Demo Project
            //WFA_PH_Demo 

    //        /*

     cs.XMin = 0;
     cs.XMax =4000 ;
     cs.YMin = 0;
     cs.YMax = 100;
     cs.ZMin = 0;
     cs.ZMax = 1;
     cs.XTick = 500;
     cs.YTick = 10;
     cs.ZTick = 1;

           ds.XDataMin = cs.XMin;
            ds.YDataMin = cs.YMin;
     ds.XSpacing = 1;// 0.3f;
     ds.YSpacing = 1;// 0.3f;
     WFA_PH_CurveDemo.Form1 f1 = new WFA_PH_CurveDemo.Form1();
     // f1.PlotPHChart("Water");//This will call the function required

     f1.DataPullFunctionForCoolProp("Water");
     Point3[,] pts = new Point3[300, 300];

     for (int i = 0; i < f1.P_Value.GetLength(0); i++)
     {
         for (int j = 0; j <f1.P_Value.GetLength(1); j++)
         {
             //pts[i, j].X = X[i, j];
             //pts[i, j].Y = Y[i, j];
             //pts[i, j].Z = Z[i, j];
             pts[i, j] = new Point3((int)f1.H_Value[j,i], (int)f1.P_Value[j, i], (int)f1.T_Value[j, i], 1);
            // pts[i, j] = new Point3((int)f1.H_Value[i, j], (int)f1.P_Value[i, j], 1, 1);

         }
     }

//*/


            ds.PointArray = pts;
        }

        public void SinROverR3D(DataSeries ds, ChartStyle cs)
        {
            cs.XMin = -8;
            cs.XMax = 8;
            cs.YMin = -8;
            cs.YMax = 8;
            cs.ZMin = -0.5f;
            cs.ZMax = 1;
            cs.XTick = 4;
            cs.YTick = 4;
            cs.ZTick = 0.5f;

            ds.XDataMin = cs.XMin;
            ds.YDataMin = cs.YMin;
            ds.XSpacing = 0.5f;
            ds.YSpacing = 0.5f;
            ds.XNumber = Convert.ToInt16((cs.XMax - cs.XMin) / ds.XSpacing) + 1;
            ds.YNumber = Convert.ToInt16((cs.YMax - cs.YMin) / ds.YSpacing) + 1;

            Point3[,] pts = new Point3[ds.XNumber, ds.YNumber];
            for (int i = 0; i < ds.XNumber; i++)
            {
                for (int j = 0; j < ds.YNumber; j++)
                {
                    float x = ds.XDataMin + i * ds.XSpacing;
                    float y = ds.YDataMin + j * ds.YSpacing;
                    float r = (float)Math.Sqrt(x * x + y * y) + 0.000001f;
                    float z = (float)Math.Sin(r) / r;
                    pts[i, j] = new Point3(x, y, z, 1);
                }
            }
            ds.PointArray = pts;
        }

        public void Exp4D(DataSeries ds, ChartStyle cs)
        {
            cs.XMin = -2;
            cs.XMax = 2;
            cs.YMin = -2;
            cs.YMax = 2;
            cs.ZMin = -2;
            cs.ZMax = 2;
            cs.XTick = 1;
            cs.YTick = 1;
            cs.ZTick = 1;

            ds.XDataMin = cs.XMin;
            ds.YDataMin = cs.YMin;
            ds.ZZDataMin = cs.ZMin;
            ds.XSpacing = 0.1f;
            ds.YSpacing = 0.1f;
            ds.ZSpacing = 0.1f;
            ds.XNumber = Convert.ToInt16((cs.XMax - cs.XMin) / ds.XSpacing) + 1;
            ds.YNumber = Convert.ToInt16((cs.YMax - cs.YMin) / ds.YSpacing) + 1;
            ds.ZNumber = Convert.ToInt16((cs.ZMax - cs.ZMin) / ds.ZSpacing) + 1;

            Point4[, ,] pts = new Point4[ds.XNumber, ds.YNumber, ds.ZNumber];
            for (int i = 0; i < ds.XNumber; i++)
            {
                for (int j = 0; j < ds.YNumber; j++)
                {
                    for (int k = 0; k < ds.ZNumber; k++)
                    {
                        float x = ds.XDataMin + i * ds.XSpacing;
                        float y = ds.YDataMin + j * ds.YSpacing;
                        float z = cs.ZMin + k * ds.ZSpacing;
                        float v = z * (float)Math.Exp(-x * x - y * y - z * z);
                        pts[i, j, k] = new Point4(new Point3(x, y, z, 1), v);
                    }
                }
            }
            ds.Point4Array = pts;
        }

    }
}
