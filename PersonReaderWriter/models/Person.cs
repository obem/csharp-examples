using System;
using System.Collections.Generic;
using System.Text;

namespace PersonReaderWriter.models
{
    /// <summary>
    /// person class
    /// </summary>
    public class Person
    {
        /// <summary>
        /// persons full name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// persons age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// persons hometown
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// persons current job
        /// </summary>
        public string Job { get; set; }
    }
}
