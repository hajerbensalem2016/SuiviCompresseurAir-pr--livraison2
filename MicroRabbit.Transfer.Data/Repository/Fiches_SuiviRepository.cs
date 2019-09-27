using MicroRabbit.GestionCompresseur.Data.Context;
using MicroRabbit.GestionCompresseur.Domain.Interfaces;
using MicroRabbit.GestionCompresseur.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MicroRabbit.GestionCompresseur.Data.Repository
{
    public class Fiches_SuiviRepository : IFiches_SuiviRepository
    {
        private readonly CompresseurDbContext _context;

        // Constructor
        public Fiches_SuiviRepository(CompresseurDbContext context)
        {
            _context = context;
        }


        // CRUD
        public string DeleteFiche_Suivi(int id)
        {
            var Fiche_Suivi = _context.Fiche_Suivis.Find(id);
            _context.Fiche_Suivis.Remove(Fiche_Suivi);
            _context.SaveChanges();

            return "delete done";
        }

        public Fiche_Suivi GetFiche_Suivi(int id)
        {
            var Fiche_Suivi = _context.Fiche_Suivis.Find(id);

            return Fiche_Suivi;
        }

        public IEnumerable<Fiche_Suivi> GetFiche_Suivis()
        {
            return _context.Fiche_Suivis.ToList();
        }

        public string PostFiche_Suivi(Fiche_Suivi fiche_Suivi)
        {
            int max = 0;
            //  int max = _context.Fiche_Suivis.Max(c => c.Index_Electrique);
            var maxpossible = _context.Fiche_Suivis.Where(c => c.CompFilialeID == fiche_Suivi.CompFilialeID &&
            DateTime.Compare(fiche_Suivi.Date, c.Date) < 0).FirstOrDefault();
            if (maxpossible != null)
            {
                max = _context.Fiche_Suivis.Where(c => c.CompFilialeID == fiche_Suivi.CompFilialeID &&
                DateTime.Compare(fiche_Suivi.Date, c.Date) < 0).Max(c => c.Index_Electrique);
            }


            string testval = testDatePost(fiche_Suivi);
            string datedouble = TestDoubleDate(fiche_Suivi);
            if (datedouble == "true")
            {
                if (testval == "true")
                {
                    if (fiche_Suivi.Nbre_Heurs_Charge < fiche_Suivi.Nbre_Heurs_Total)
                    {
                        if (fiche_Suivi.Index_Electrique >= max)
                        {
                            _context.Fiche_Suivis.Add(fiche_Suivi);
                            _context.SaveChanges();

                            return "Added done  " + fiche_Suivi.FicheSuiviID;
                        }
                        else
                            return "Index lower than the previous index";
                    }
                    else
                        return "Total number of hours less than the number of hours in charge";

                }
                else
                    return testval;
            }
            else
                return datedouble;

        }

        public string PutFiche_Suivi(int id, Fiche_Suivi fiche_Suivi)
        {

            int max = _context.Fiche_Suivis.Where(c => c.CompFilialeID == fiche_Suivi.CompFilialeID).Max(c => c.Index_Electrique);
            string testval = testDatePut(fiche_Suivi);

            if (testval == "true")
            {
                if (fiche_Suivi.Nbre_Heurs_Charge < fiche_Suivi.Nbre_Heurs_Total)
                {
                    if (fiche_Suivi.Index_Electrique >= max)
                    {
                        {
                            var entity = _context.Fiche_Suivis.Find(id);
                            if (entity != null)
                            {
                                entity.Date = fiche_Suivi.Date;
                                entity.Nbre_Heurs_Total = fiche_Suivi.Nbre_Heurs_Total;
                                entity.Nbre_Heurs_Charge = fiche_Suivi.Nbre_Heurs_Charge;
                                entity.Index_Electrique = fiche_Suivi.Index_Electrique;
                                entity.TempsArret = fiche_Suivi.TempsArret;
                                entity.Etat = fiche_Suivi.Etat;
                                entity.FréquenceEentretienDeshuileur = fiche_Suivi.FréquenceEentretienDeshuileur;
                                entity.TypeDernierEntretien = fiche_Suivi.TypeDernierEntretien;
                                entity.PriseCompteur = fiche_Suivi.PriseCompteur;
                                entity.THuileC = fiche_Suivi.THuileC;
                                entity.TSécheurC = fiche_Suivi.TSécheurC;
                                entity.Remarques = fiche_Suivi.Remarques;


                                // _context.Entry(entity).State = EntityState.Modified;
                                _context.SaveChanges();
                                return "Update done  " + id;
                            }
                            else
                            {
                                return "Fiche suivi don't exist";
                            }
                        }
                    }
                    else
                        return "Index lower than the previous index";
                }
                else
                    return "Total number of hours less than the number of hours in charge";
            }
            else
                return testval;

        }
        //pour tester la contrainte date:
        //Le saisi du premier jour de chaque mois ne se fait qu’après le saisi
        //du dernier jour de mois précédant
        public string testDatePost(Fiche_Suivi fiche_Suivi)
        {
            int value = DateTime.Compare(fiche_Suivi.Date, DateTime.Now);
            if (value <= 0)
            {

                if (fiche_Suivi.Date.DayOfWeek != DayOfWeek.Saturday && fiche_Suivi.Date.DayOfWeek != DayOfWeek.Sunday)

                {
                    var exist = _context.Fiche_Suivis.Where(c => c.CompFilialeID == fiche_Suivi.CompFilialeID).FirstOrDefault();
                    if (exist != null)
                    {
                        DateTime date2;
                        int annee = fiche_Suivi.Date.Year;
                        int mois = fiche_Suivi.Date.Month - 1;
                        if (mois == 0)
                        {
                            mois = 12;
                            annee--;
                        }
                        int last = DateTime.DaysInMonth(annee, mois);
                        DateTime date = new DateTime(annee, mois, last);

                        if (date.DayOfWeek == DayOfWeek.Saturday)
                        {
                            date2 = new DateTime(annee, mois, last - 1);
                        }
                        else if (date.DayOfWeek != DayOfWeek.Sunday)
                        {
                            date2 = new DateTime(annee, mois, last - 2);
                        }
                        else
                        {
                            date2 = new DateTime(annee, mois, last);
                        }
                        var res = _context.Fiche_Suivis.Where(c => c.Date == date2).FirstOrDefault();
                        if (res != null)
                            return "true";
                        else
                            return "The last day of the previous month not completed";
                    }
                    else
                        return "true";

                }
                return "Week-end";
            }
            else
                return "Date superior to the date of today";

        }

        public string testDatePut(Fiche_Suivi fiche_Suivi)
        {
            int value = DateTime.Compare(fiche_Suivi.Date, DateTime.Now);
            if (value <= 0)
            {

                if (fiche_Suivi.Date.DayOfWeek != DayOfWeek.Saturday && fiche_Suivi.Date.DayOfWeek != DayOfWeek.Sunday)

                {

                    DateTime date2;
                    int annee = fiche_Suivi.Date.Year;
                    int mois = fiche_Suivi.Date.Month - 1;
                    if (mois == 0)
                    {
                        mois = 12;
                        annee--;
                    }
                    int last = DateTime.DaysInMonth(annee, mois);
                    DateTime date = new DateTime(annee, mois, last);

                    if (date.DayOfWeek == DayOfWeek.Saturday)
                    {
                        date2 = new DateTime(annee, mois, last - 1);
                    }
                    else if (date.DayOfWeek != DayOfWeek.Sunday)
                    {
                        date2 = new DateTime(annee, mois, last - 2);
                    }
                    else
                    {
                        date2 = new DateTime(annee, mois, last);
                    }
                    var res = _context.Fiche_Suivis.Where(c => c.Date == date2).FirstOrDefault();
                    if (res != null)
                        return "true";
                    else
                        return "The last day of the previous month not completed";


                }
                return "Week-end";
            }
            else
                return "Date superior to the date of today";

        }




        public string TestDoubleDate(Fiche_Suivi fiche_Suivi)
        {
            var doubledate = _context.Fiche_Suivis.Where(c => c.CompFilialeID == fiche_Suivi.CompFilialeID && c.Date == fiche_Suivi.Date).FirstOrDefault();
            if (doubledate == null)
                return "true";
            else
                return "Existing Fiche_suivi at this date";
        }


    }
}
