using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class EMSDataService
    {
        partial void Countries_Updating(Country entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Countries_Inserting(Country entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void States_Inserting(State entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void States_Updating(State entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Cities_Inserting(City entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Cities_Updating(City entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void AcademicYearSetups_Inserting(AcademicYearSetup entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void AcademicYearSetups_Updating(AcademicYearSetup entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void SchoolSetups_Inserting(SchoolSetup entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void SchoolSetups_Updating(SchoolSetup entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
            string name = Application.User.Name;
        }

        partial void Religions_Inserting(Religion entity)
        {

        }

        partial void Religions_Updating(Religion entity)
        {

        }

        partial void Nationalities_Inserting(Nationality entity)
        {

        }

        partial void Nationalities_Updating(Nationality entity)
        {

        }

        partial void MotherTongues_Inserting(MotherTongue entity)
        {

        }

        partial void MotherTongues_Updating(MotherTongue entity)
        {

        }

        partial void BloodGroups_Inserting(BloodGroup entity)
        {

        }

        partial void BloodGroups_Updating(BloodGroup entity)
        {

        }

        partial void Castes_Inserting(Caste entity)
        {

        }

        partial void Castes_Updating(Caste entity)
        {

        }

        partial void ReservationCategories_Inserting(ReservationCategory entity)
        {

        }

        partial void ReservationCategories_Updating(ReservationCategory entity)
        {

        }

        partial void Occupations_Inserting(Occupation entity)
        {

        }

        partial void Occupations_Updating(Occupation entity)
        {

        }

        partial void GameHouses_Inserting(GameHous entity)
        {

        }

        partial void GameHouses_Updating(GameHous entity)
        {

        }
    }
}
