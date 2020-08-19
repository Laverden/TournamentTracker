using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PRIZES_FILE = "PrizeModels.csv";
        private const string PEOPLE_FILE = "PersonModels.csv";
        private const string TEAMS_FILE = "TeamModels.csv";

        /// <summary>
        /// Saves a new person to a text file.
        /// </summary>
        /// <param name="model">The person information</param>
        /// <returns>The person information, including the unique identifier.</returns>
        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file and convert it to List<PersonModel>.
            List<PersonModel> people = PEOPLE_FILE.FullFilePath().LoadFile().ConvertToPersonModels();

            // Find the highest ID and add the new record with the new ID.
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            // Convert the persons to a List<string> and save it to the text file.
            people.SaveToPeopleFile(PEOPLE_FILE);

            return model;
        }

        /// <summary>
        /// Saves a new prize to a text file.
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file and convert it to List<PrizeModel>.
            List<PrizeModel> prizes = PRIZES_FILE.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the highest ID and add the new record with the new ID.
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            prizes.Add(model);

            // Convert the prizes to a List<string> and save it to the text file.
            prizes.SaveToPrizeFile(PRIZES_FILE);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TEAMS_FILE.FullFilePath().LoadFile().ConvertToTeamModels(PEOPLE_FILE);

            // Find the highest ID and add the new record with the new ID.
            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TEAMS_FILE);

            return model;
        }

        public List<PersonModel> GetPersonal_All()
        {
            return PEOPLE_FILE.FullFilePath().LoadFile().ConvertToPersonModels();
        }
    }
}
