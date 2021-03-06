// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The set of changes to be made to a job schedule.
    /// </summary>
    public partial class JobSchedulePatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobSchedulePatchParameter class.
        /// </summary>
        public JobSchedulePatchParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobSchedulePatchParameter class.
        /// </summary>
        /// <param name="schedule">The schedule according to which jobs will be
        /// created.</param>
        /// <param name="jobSpecification">The details of the jobs to be
        /// created on this schedule.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job schedule as metadata.</param>
        public JobSchedulePatchParameter(Schedule schedule = default(Schedule), JobSpecification jobSpecification = default(JobSpecification), System.Collections.Generic.IList<MetadataItem> metadata = default(System.Collections.Generic.IList<MetadataItem>))
        {
            Schedule = schedule;
            JobSpecification = jobSpecification;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the schedule according to which jobs will be created.
        /// </summary>
        /// <remarks>
        /// If you do not specify this element, the existing schedule is left
        /// unchanged.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Gets or sets the details of the jobs to be created on this
        /// schedule.
        /// </summary>
        /// <remarks>
        /// Updates affect only jobs that are started after the update has
        /// taken place. Any currently active job continues with the older
        /// specification.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobSpecification")]
        public JobSpecification JobSpecification { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job
        /// schedule as metadata.
        /// </summary>
        /// <remarks>
        /// If you do not specify this element, existing metadata is left
        /// unchanged.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.JobSpecification != null)
            {
                this.JobSpecification.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element in this.Metadata)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
