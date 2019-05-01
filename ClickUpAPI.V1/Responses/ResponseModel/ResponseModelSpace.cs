﻿using Newtonsoft.Json;
using PaironsTech.ApiHelper.Interfaces;
using System.Collections.Generic;

namespace PaironsTech.ClickUpAPI.V1.Responses.Model
{

    /// <summary>
    /// Model object of Space information response
    /// </summary>
    public class ResponseModelSpace : IResponseModel
    {

        /// <summary>
        /// Id of the Space
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the Space
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Check if the Space is Private
        /// </summary>
        [JsonProperty("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// List of Model Status with the statuses of the Space
        /// </summary>
        [JsonProperty("statuses")]
        public List<ResponseModelStatus> Statuses { get; set; }

        /// <summary>
        /// Check if it's active multiple assignees in this Space
        /// </summary>
        [JsonProperty("multiple_assignees")]
        public bool? MultipleAssignees { get; set; }
        
        /// <summary>
        /// Model Feature Object that contains the information about features of this Space
        /// </summary>
        [JsonProperty("features")]
        public ResponseModelFeatures Features { get; set; }

        /// <summary>
        /// List of Model User Object with the informations about the members of the Space
        /// </summary>
        [JsonProperty("members")]
        public List<ResponseModelUser> Members { get; set; }

    }

}