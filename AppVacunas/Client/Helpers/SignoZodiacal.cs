using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Client.Helpers {

    public class SignoZodiacal {

        public static string GetSigno(string fecha) {
            string mes, fechaNacimiento;
            int dia;

            fechaNacimiento = fecha.Substring(0, 9);
            mes = fechaNacimiento.Substring(0, 3);
            dia = int.Parse(fechaNacimiento.Substring(3, 5));

            // Acuario
            // Enero 20 hasta Febrero 18
            if ((mes == "01" && dia >= 20) || (mes == "02" && dia <= 18)) {
                return "Acuario";
            }

            //Piscis
            //Febrero 19 hasta marzo 20
            if ((mes == "02" && dia >= 19) || (mes == "03" && dia <= 20)) {
                return "Piscis";
            }

            //Aries
            //marzo 21 hasta abril 19
            if ((mes == "03" && dia >= 21) || (mes == "04" && dia <= 19)) {
                return "Aries";
            }

            //Tauro
            //Abril 20 hasta Mayo 20
            if ((mes == "04" && dia >= 20) || (mes == "05" && dia <= 20)) {
                return "Tauro";
            }

            //Gemenis
            //Mayo 21 hasta Junio 20
            if ((mes == "05" && dia >= 20) || (mes == "06" && dia <= 20)) {
                return "Geminis";
            }

            //Cancer
            //Junio 21 hasta Julio 22
            if ((mes == "06" && dia >= 21) || (mes == "07" && dia <= 22)) {
                return "Cancer";
            }
            //Leo
            //Julio 23 hasta Agosto 22
            if ((mes == "07" && dia >= 23) || (mes == "08" && dia <= 22)) {
                return "Leo";
            }

            //Virgo
            //Agosto 23 hasta Septiembre 22
            if ((mes == "08" && dia >= 23) || (mes == "09" && dia <= 22)) {
                return "Virgo";
            }

            //Libra
            //Septiembre 23 hasta Octubre 22
            if ((mes == "09" && dia >= 23) || (mes == "10" && dia <= 22)) {
                return  "Libra";
            }

            //Escorpio
            //Octubre 23 hasta Noviembre 21
            if ((mes == "10" && dia >= 23) || (mes == "11" && dia <= 21)) {
                return "Escorpio";
            }
            //Sagitario
            //Noviembre 22 hasta Diciembre 21
            if ((mes == "11" && dia >= 22) || (mes == "12" && dia <= 21)) {
                return "Sagitario";
            }
            //Capricornio
            //Diciembre 22 hasta Enero 19
            if ((mes == "12" && dia >= 22) || (mes == "01" && dia <= 19)) {
                return "Capricornio";
            }

            return "";

        }
    }
}
