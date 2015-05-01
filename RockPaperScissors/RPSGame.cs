using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RPSGame
    {
        public RPSGame(params string[] weapons)
        {
            Weapons = weapons;

            // Creates a new AI opponent, and gives it the list of weapons.
            _rpsAI = new RPSAI(weapons);
        }

        // Play next turn.
        public int Next(string weapon)
        {
            string aiWeapon = _rpsAI.NextMove(); // Gets the AI opponent's next move.
            LastAIWeapon = aiWeapon; // Saves the AI opponent's move in a property so the player can see it.

            _rpsAI.AddPlayerMove(weapon); // Let the AI know which weapon the player chose, for future predictions.
            return GetWinner(Weapons, weapon, aiWeapon); // Returns -1 if AI win, 0 if draw, and 1 if player win.
        }

        // Returns matchup winner.
        public static int GetWinner(string[] weapons, string weapon1, string weapon2)
        {
            if (weapon1 == weapon2)
                return 0; // If weapons are the same, return 0 for draw.

            if (GetVictories(weapons, weapon1).Contains(weapon2))
                return 1; // Returns 1 for weapon1 win.
            else if (GetVictories(weapons, weapon2).Contains(weapon1))
                return -1; // Returns -1 for weapon2 win.

            throw new Exception("No winner found.");
        }

        /* 
         * Return weapons that the provided weapon beats.
         * The are calculated in the following way:
         * If the index of the weapon is even, then all even indices less than it,
         * and all odd indices greater than it, are victories.
         * One exception is if it is an odd index, and also the last index in the set,
         * then the first index in the set is a victory.
         */
        public static IEnumerable<string> GetVictories(string[] weapons, string weapon)
        {
            // Gets index of weapon.
            int index = Array.IndexOf(weapons, weapon);

            // If weapon is odd and the final index in the set, then return the first item in the set as a victory.
            if (index % 2 != 0 && index == weapons.Length - 1)
                yield return weapons[0];

            for (int i = index - 2; i >= 0; i -= 2)
                yield return weapons[i];

            for (int i = index + 1; i < weapons.Length; i += 2)
                yield return weapons[i];
        }

        public string LastAIWeapon
        {
            private set;
            get;
        }

        public readonly string[] Weapons;
        private RPSAI _rpsAI;

        class RPSAI
        {
            public RPSAI(params string[] weapons)
            {
                _weapons = weapons;
                _weaponProbability = new Dictionary<string, int>();

                // The AI sets the probability for each weapon to be chosen as 1.
                foreach (string weapon in weapons)
                    _weaponProbability.Add(weapon, 1);

                _random = new Random();
            }

            // Increases probability of selecting each weapon that beats the provided move.
            public void AddPlayerMove(string weapon)
            {
                int index = Array.IndexOf(_weapons, weapon);

                foreach (string winWeapon in _weapons.Except(GetVictories(_weapons, weapon)))
                    if (winWeapon != weapon)
                        _weaponProbability[winWeapon]++;
            }

            // Gets the AI's next move.
            public string NextMove()
            {
                double r = _random.NextDouble();

                double divisor = _weaponProbability.Values.Sum();

                var weightedWeaponRanges = new Dictionary<double, string>();

                double currentPos = 0.0;

                // Maps probabilities to ranges between 0.0 and 1.0. Returns weighted random weapon.
                foreach (var weapon in _weaponProbability)
                {
                    double weightedRange = weapon.Value / divisor;
                    if (r <= currentPos + (weapon.Value / divisor))
                        return weapon.Key;
                    currentPos += weightedRange;
                }

                throw new Exception("Error calculating move.");
            }

            Random _random;
            private readonly string[] _weapons;
            private Dictionary<string, int> _weaponProbability;
        }
    }
}
