using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - Create Names
/// - Set Individual Name
/// - Set Team Character Names
/// </summary>
public class CharacterNameGenerator : MonoBehaviour
{
    public enum firstNames {Samantha, Emma, Ashley};
    public enum lastNames {Murphy, Cook, West}
    public enum nicknames {Sam, Em, Ash}

    public firstNames currentFirstName;
    public lastNames currentLastName;
    public nicknames currentNickname;
    private void Awake()
    {
        // call the create names function
        CreateNames();
    }

    /// <summary>
    /// Creates a list of names for all our characters to potential use.
    /// </summary>
    public void CreateNames()
    {
        // So here we would ideally want to be able to add some names to our first names, last names and nick names lists.
        
        // (At beginning of class)
    }

    /// <summary>
    /// set a characters name to a random value in our Part 02
    /// </summary>
    /// <param name="character"></param>
    public void SetIndividualCharacter(CharacterName character)
    {
        // So here rather than each character being called Blanky Blank Blank, we probably want it to be a random first,last and nickname

        currentFirstName = (firstNames)Random.Range(0, 3);
        currentLastName = (lastNames)Random.Range(0, 3);
        currentNickname = (nicknames)Random.Range(0, 3);

    }

    /// <summary>
    /// sets a character name for each member of a team, this is in our part 03
    /// </summary>
    /// <param name="namesNeeded"></param>
    /// <returns></returns>
    public void SetTeamCharacterNames(List<CharacterName> teamCharacters)
    {
        // so here we have a list of character names coming in.
        // we should probably loop over that list of charcter names, and then for each chacter set their first, last and nickname a random one from our lists
        // if you want to get fancy you could use another function within this script to help out here.

        for (int i = 0; i < teamCharacters.Count; i++)
        {
            teamCharacters[i].firstName = ((firstNames)Random.Range(0, 3)).ToString();
            teamCharacters[i].lastName = ((lastNames)Random.Range(0, 3)).ToString();
            teamCharacters[i].nickName = ((nicknames)Random.Range(0, 3)).ToString();
        }
    }
}