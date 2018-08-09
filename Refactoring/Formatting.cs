using System;
using System.Collections.Generic;

namespace Refactoring
{
    public class PersonRepository
    {
        public bool Caching { get; set; }
        public DateTime LastRequest { get; set; }
    }

    #region Don't mind

    /// @formatter:int_align_properties False

    #endregion

    public class PersonDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public List<string> Hobbies { get; set; }
    }

    #region Don't mind

    // @formatter:int_align_properties restore

    #endregion
}