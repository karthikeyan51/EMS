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
            
        }

        partial void Religions_Inserting(Religion entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Religions_Updating(Religion entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Nationalities_Inserting(Nationality entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Nationalities_Updating(Nationality entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void MotherTongues_Inserting(MotherTongue entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void MotherTongues_Updating(MotherTongue entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void BloodGroups_Inserting(BloodGroup entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void BloodGroups_Updating(BloodGroup entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Castes_Inserting(Caste entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Castes_Updating(Caste entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void ReservationCategories_Inserting(ReservationCategory entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void ReservationCategories_Updating(ReservationCategory entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Occupations_Inserting(Occupation entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void Occupations_Updating(Occupation entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void GameHouses_Inserting(GameHouse entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void GameHouses_Updating(GameHouse entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void RelievingTypes_Inserting(RelievingType entity)
        {
            entity.InsertDate = DateTime.Now;
            entity.InsertUser = Application.User.Name;
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }

        partial void RelievingTypes_Updating(RelievingType entity)
        {
            entity.UpdateDate = DateTime.Now;
            entity.UpdateUser = Application.User.Name;
        }
    }
}
