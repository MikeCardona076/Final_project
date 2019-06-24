using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_proyect_finall
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion_menu = 0;
            


            //Menu del usuario
            Console.WriteLine(" Hello. This is Mike's Matrix Calculator  ");
            Console.WriteLine(" 1 Sum  ");
            Console.WriteLine(" 2 subtraction");
            Console.WriteLine(" 3 divi  ");
            Console.WriteLine(" 4 Gauss ");
            Console.WriteLine(" 5 Gauss Jordan  ");
            Console.WriteLine(" 6 Inverse matrix  ");
            Console.WriteLine(" 7 Cramer  ");

            // Aqui tomamos la eleccion del usuario 
            Console.WriteLine(" Insert your choice ");
            eleccion_menu = int.Parse(Console.ReadLine());


            // Con ayuda del switch le damos la opcion al usuario de escoger lo que quiera del menu
            switch (eleccion_menu)
            {
                case 1:
                    Console.WriteLine(" 1  ");
                    break;

                case 2:
                    Console.WriteLine(" 1  ");
                    break;

                case 3:
                    Console.WriteLine(" 1  ");
                    break;

                case 4:
                    Console.WriteLine("La Matriz a resolver");
                    Console.WriteLine(" ---           ---");
                    Console.WriteLine("| X11 X12 X13 | T1 ");
                    Console.WriteLine("| X21 X22 X23 | T2 ");
                    Console.WriteLine("| X31 X32 X33 | T3 ");
                    Console.WriteLine(" ---           ---");

                    //Aqui se establecen los valores
                    Console.WriteLine("Ingresa el valor de X11");
                    double x11 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X12");
                    double x12 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X13");
                    double x13 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de t1");
                    double t1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X21");
                    double x21 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X22");
                    double x22 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X23");
                    double x23 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de t2");
                    double t2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X31");
                    double x31 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X32");
                    double x32 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de X33");
                    double x33 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de t3");
                    double t3 = double.Parse(Console.ReadLine());

                    Console.Clear();
                    double divi = x11;
                    //aqui transformamos el valor de x11 en 1
                    if (x11 > 0)
                    {
                        x11 = (x11 / divi);
                        x12 = (x12 / divi);
                        x13 = (x13 / divi);
                        t1 = (t1 / divi);
                    }
                    if (x11 < 0)
                    {
                        x11 = (x11 / divi);
                        x12 = (x12 / divi);
                        x13 = (x13 / divi);
                        t1 = (t1 / divi);
                    }

                    double multi = x21;
                    //aqui transformacion el valor x21 en 0
                    if (x21 != 0)
                    {
                        if (x21 < 0)
                        {
                            x21 = (multi * x11) - x21;
                            x22 = (multi * x12) - x22;
                            x23 = (multi * x13) - x23;
                            t2 = (multi * t1) - t2;
                        }
                        if (x21 > 0)
                        {
                            x21 = (-multi * x11) + x21;
                            x22 = (-multi * x12) + x22;
                            x23 = (-multi * x13) + x23;
                            t2 = (-multi * t1) + t2;
                        }
                    }

                    multi = x31;
                    //aqui transformamos x31 en 0
                    if (x31 != 0)
                    {
                        if (x31 < 0)
                        {
                            x31 = (multi * x11) - x31;
                            x32 = (multi * x12) - x32;
                            x33 = (multi * x13) - x33;
                            t3 = (multi * t1) - t3;
                        }
                        if (x31 > 0)
                        {
                            x31 = (-multi * x11) + x31;
                            x32 = (-multi * x12) + x32;
                            x33 = (-multi * x13) + x33;
                            t3 = (-multi * t1) + t3;
                        }
                    }

                    double divis = x22;
                    //aqui transformamos x22 en 1
                    if (x22 > 1)
                    {
                        x21 = (x21 / divis);
                        x22 = (x22 / divis);
                        x23 = (x23 / divis);
                        t2 = (t2 / divis);
                    }
                    if (x22 < 1)
                    {
                        x21 = (x21 / divis);
                        x22 = (x22 / divis);
                        x23 = (x23 / divis);
                        t2 = (t2 / divis);
                    }

                    multi = x32;
                    //aqui trasnformamos x32 en 0
                    if (x32 != 0)
                    {
                        if (x32 < 0)
                        {
                            x31 = (multi * x21) - x31;
                            x32 = (multi * x22) - x32;
                            x33 = (multi * x23) - x33;
                            t3 = (multi * t2) - t3;
                        }
                        if (x32 > 0)
                        {
                            x31 = (-multi * x21) + x31;
                            x32 = (-multi * x22) + x32;
                            x33 = (-multi * x23) + x33;
                            t3 = (-multi * t2) + t3;
                        }
                    }

                    divis = x33;
                    //aqui dice que si los valores x33 y el t3 son 0 son homogenea
                    if (t3 == 0 && x33 == 0)
                    {

                    }
                    else
                    {
                        //aqui transformamos el valor x33 en 1
                        if (x33 > 1)
                        {
                            x31 = (x31 / divis);
                            x32 = (x32 / divis);
                            x33 = (x33 / divis);
                            t3 = (t3 / divis);
                        }
                        if (x33 < 1)
                        {
                            x31 = (x31 / divis);
                            x32 = (x32 / divis);
                            x33 = (x33 / divis);
                            t3 = (t3 / divis);
                        }
                    }
                    Console.WriteLine(" ---           ---");
                    Console.WriteLine("|  " + x11 + "  " + x12 + "  " + x13 + " | " + t1 + " ");
                    Console.WriteLine("|  " + x21 + "  " + x22 + "  " + x23 + " | " + t2 + " ");
                    Console.WriteLine("|  " + x31 + "  " + x32 + "  " + x33 + " | " + t3 + " ");
                    Console.WriteLine(" ---           ---");

                    Console.WriteLine(" ---           ---");
                    double z = t3;
                    Console.WriteLine("Z = " + z);
                    double y = t2 - (x23 * z);
                    Console.WriteLine("Y = " + y);
                    double x = t1 - ((x12 * y) + (x13 * z));
                    Console.WriteLine("X = " + x);
                    Console.WriteLine(" ---           ---");

                    Console.ReadLine();

                    break;
                    
                case 5:
                    Console.WriteLine("La Matriz a resolver");
                    Console.WriteLine("| m11 m12 m13 | m1 ");
                    Console.WriteLine("| m21 m22 m23 | m2 ");
                    Console.WriteLine("| m31 m32 m33 | T3 ");
                    Console.WriteLine(" ---           ---");

                    //Aqui se establecen los valores
                    Console.WriteLine("Ingresa el valor de m11");
                    double  m11 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de m12");
                    double m12 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor de m13");
                    double m13 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m1");
                    double m1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m21");
                    double m21 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m22");
                    double m22 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m23");
                    double m23 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m2");
                    double m2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m31");
                    double m31 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m32");
                    double m32 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor m33");
                    double m33 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el valor T3");
                    double m3 = double.Parse(Console.ReadLine());
                    Console.Clear();


                    Console.WriteLine("|  " + m11 + "  " + m12 + "  " + m13 + " | " + m1 + " ");
                    Console.WriteLine("|  " + m21 + "  " + m22 + "  " + m23 + " | " + m2 + " ");
                    Console.WriteLine("|  " + m31 + "  " + m32 + "  " + m33 + " | " + m3 + " ");
                    Console.WriteLine(" ---           ---");
                    double mdivi = m11;
                    //aqui transformamos el valor de m11 en 1
                    if (m11 > 0)
                    {
                        m11 = (m11 / mdivi);
                        m12 = (m12 / mdivi);
                        m13 = (m13 / mdivi);
                        m1 = (m1 / mdivi);
                    }
                    if (m11 < 0)
                    {
                        m11 = (m11 / mdivi);
                        m12 = (m12 / mdivi);
                        m13 = (m13 / mdivi);
                        m1 = (m1 / mdivi);
                    }

                    double mmdivi = m21;
                    //aqui transformacion el valor m21 en 0
                    if (m21 != 0)
                    {
                        if (m21 < 0)
                        {
                            m21 = (mmdivi * m11) - m21;
                            m22 = (mmdivi * m12) - m22;
                            m23 = (mmdivi * m13) - m23;
                            m2 = (mmdivi * m1) - m2;
                        }
                        if (m21 > 0)
                        {
                            m21 = (-mmdivi * m11) + m21;
                            m22 = (-mmdivi * m12) + m22;
                            m23 = (-mmdivi * m13) + m23;
                            m2 = (-mmdivi * m1) + m2;
                        }
                    }

                    mmdivi = m31;
                    //aqui transformamos m31 en 0
                    if (m31 != 0)
                    {
                        if (m31 < 0)
                        {
                            m31 = (mmdivi * m11) - m31;
                            m32 = (mmdivi * m12) - m32;
                            m33 = (mmdivi * m13) - m33;
                            t3 = (mmdivi * m1) - m3;
                        }
                        if (m31 > 0)
                        {
                            m31 = (-mmdivi * m11) + m31;
                            m32 = (-mmdivi * m12) + m32;
                            m33 = (-mmdivi * m13) + m33;
                            t3 = (-mmdivi * m1) + m3;
                        }
                    }

                    double mdivis = m22;
                    //aqui transformamos m22 en 1
                    if (m22 > 1)
                    {
                        m21 = (m21 / mdivis);
                        m22 = (m22 / mdivis);
                        m23 = (m23 / mdivis);
                        m2 = (m2 / mdivis);
                    }
                    if (m22 < 1)
                    {
                        m21 = (m21 / mdivis);
                        m22 = (m22 / mdivis);
                        m23 = (m23 / mdivis);
                        m2 = (m2 / mdivis);
                    }

                    mmdivi = m32;
                    //aqui trasnformamos m32 en 0
                    if (m32 != 0)
                    {
                        if (m32 < 0)
                        {
                            m31 = (mmdivi * m21) - m31;
                            m32 = (mmdivi * m22) - m32;
                            m33 = (mmdivi * m23) - m33;
                            t3 = (mmdivi * m2) - m3;
                        }
                        if (m32 > 0)
                        {
                            m31 = (-mmdivi * m21) + m31;
                            m32 = (-mmdivi * m22) + m32;
                            m33 = (-mmdivi * m23) + m33;
                            t3 = (-mmdivi * m2) + m3;
                        }
                    }

                    mmdivi = m12;
                    //aqui trasnformamos m12 en 0
                    if (m12 != 0)
                    {
                        if (m12 < 0)
                        {

                            m12 = (mmdivi * m22) - m12;
                            m13 = (mmdivi * m23) - m13;
                            m1 = (mmdivi * m2) - m1;

                        }

                        if (m12 > 0)
                        {
                            m12 = (-mmdivi * m22) + m12;
                            m13 = (-mmdivi * m23) + m13;
                            m1 = (-mmdivi * m2) + m1;
                        }

                    }

                    mdivis = m33;
                    //aqui dice que si los valores m33 y el t3 son 0 son homogenea
                    if (m3 == 0 && m33 == 0)
                    {

                    }
                    else
                    {
                        //aqui transformamos el valor m33 en 1
                        if (m33 > 1)
                        {
                            m31 = (m31 / mdivis);
                            m32 = (m32 / mdivis);
                            m33 = (m33 / mdivis);
                            t3 = (m3 / mdivis);
                        }
                        if (m33 < 1)
                        {
                            m31 = (m31 / mdivis);
                            m32 = (m32 / mdivis);
                            m33 = (m33 / mdivis);
                            m3 = (m3 / mdivis);
                        }
                    }

                    mmdivi = m13;
                    //aqui trasnformamos m12 en 0
                    if (m13 != 0)
                    {
                        if (m13 < 0)
                        {

                            m13 = (mmdivi * m33) - m13;
                            m1 = (mmdivi * m3) - m1;

                        }
                        if (m13 > 0)
                        {
                            m13 = (-mmdivi * m33) + m13;
                            m1 = (-mmdivi * m3) + m1;
                        }
                    }
                    mmdivi = m23;
                    //aqui trasnformamos m12 en 0
                    if (m23 != 0)
                    {
                        if (m23 < 0)
                        {

                            m23 = (mmdivi * m33) - m23;
                            m2 = (mmdivi * m3) - m2;

                        }

                        if (m23 > 0)
                        {

                            m23 = (-mmdivi * m33) + m23;
                            m2 = (-mmdivi * m3) + m2;
                        }

                    }
                    Console.WriteLine("|  " + m11 + "  " + m12 + "  " + m13 + " | " + m1 + " ");
                    Console.WriteLine("|  " + m21 + "  " + m22 + "  " + m23 + " | " + m2 + " ");
                    Console.WriteLine("|  " + m31 + "  " + m32 + "  " + m33 + " | " + m3 + " ");
                    break;

                case 6:
                    Console.WriteLine(" 1  ");
                    break;

                case 7:
                    Console.WriteLine(" 1  ");
                    break;
          
                default:
                    Console.WriteLine(" Bien hijo");
                    break;
            }

            Console.ReadKey();
        }
    }
}
