﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.2.4.0 (NJsonSchema v9.13.36.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

namespace VelocityEhs.Service.InternalApi.Ehs.InstanceApi.Controllers
{
    #pragma warning disable

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.2.4.0 (NJsonSchema v9.13.36.0 (Newtonsoft.Json v11.0.0.0))")]
    public interface IUsersController
    {
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <param name="hierarchyId">The hierarchy identifier</param>
        /// <param name="locationStatuses">The array of selected status unique identifier will be among Active = 0, Inactive = 1, Archived = 2</param>
        /// <param name="limit">The amount of locations return per request</param>
        /// <param name="offset">The postion for first location to be returned in the collection</param>
        /// <response code="200">A list of locations founded using provided criterias</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Locations not found</response>
        /// <returns>A list of locations founded using provided criterias</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Location>>> GetUsersAsync(int? id, int? locationType, int? hierarchyId, System.Collections.Generic.IEnumerable<int> locationStatuses, int? limit, int? offset);
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.2.4.0 (NJsonSchema v9.13.36.0 (Newtonsoft.Json v11.0.0.0))")]
    [Microsoft.AspNetCore.Mvc.Route("api")]
    public partial class UsersController : Microsoft.AspNetCore.Mvc.ApiController
    {
        private IUsersController implementation;
    
        public UsersController(IUsersController implementation)
        {
            this.implementation = implementation;
        }
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <param name="hierarchyId">The hierarchy identifier</param>
        /// <param name="locationStatuses">The array of selected status unique identifier will be among Active = 0, Inactive = 1, Archived = 2</param>
        /// <param name="limit">The amount of locations return per request</param>
        /// <param name="offset">The postion for first location to be returned in the collection</param>
        /// <response code="200">A list of locations founded using provided criterias</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Locations not found</response>
        /// <returns>A list of locations founded using provided criterias</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("users")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Location>>> GetUsers(int? id, int? locationType, int? hierarchyId, System.Collections.Generic.IEnumerable<int> locationStatuses, int? limit, int? offset)
        {
            return this.implementation.GetUsersAsync(id, locationType, hierarchyId, locationStatuses, limit, offset);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.2.4.0 (NJsonSchema v9.13.36.0 (Newtonsoft.Json v11.0.0.0))")]
    public interface ILocationsController
    {
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <param name="hierarchyId">The hierarchy identifier</param>
        /// <param name="locationStatuses">The array of selected status unique identifier will be among Active = 0, Inactive = 1, Archived = 2</param>
        /// <param name="limit">The amount of locations return per request</param>
        /// <param name="offset">The postion for first location to be returned in the collection</param>
        /// <response code="200">A list of locations founded using provided criterias</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Locations not found</response>
        /// <returns>A list of locations founded using provided criterias</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Location>>> GetLocationsAsync(int? id, int? locationType, int? hierarchyId, System.Collections.Generic.IEnumerable<int> locationStatuses, int? limit, int? offset);
    
        /// <param name="body">The updated location schema</param>
        /// <response code="200">The updated location</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <response code="422">Fail to update selected location</response>
        /// <returns>The updated location</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Location>> UpdateLocationAsync(Location body);
    
        /// <param name="body">The new location schema</param>
        /// <response code="201">The new location</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="422">Fail to create new location</response>
        /// <returns>The new location</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Location>> CreateLocationAsync(NewLocationParams body);
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <response code="204">Location deletion result</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <response code="422">Fail to delete selected location</response>
        /// <returns>Location deletion result</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> DeleteLocationAsync(int id, int locationType);
    
        /// <param name="locationId">The location identifier</param>
        /// <param name="locationType">Location type of selected location. Group = 0, Location = 1</param>
        /// <response code="200">A location with provided identifier</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <returns>A location with provided identifier</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Location>> GetLocationByIdAsync(int locationId, int? locationType);
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <param name="hierarchyId">The hierarchy identifier</param>
        /// <param name="locationStatuses">The array of selected statuses</param>
        /// <param name="levels">The number of level to traverse within hierarchy</param>
        /// <response code="200">A list of locations founded using provided criterias</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Locations not found</response>
        /// <returns>A list of locations founded using provided criterias</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Location>>> GetTraversedLocationsAsync(int id, int locationType, int hierarchyId, System.Collections.Generic.IEnumerable<int> locationStatuses, int? levels);
    
        /// <response code="201">The updated location</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Location not found</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="422">Fail to update selected location</response>
        /// <returns>The updated location</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> MoveLocationAsync(MovingLocationParams body);
    
        /// <param name="body">The new location object</param>
        /// <response code="204">Create location validation result</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <returns>Create location validation result</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> CanCreateLocationAsync(NewLocationParams body);
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <response code="204">Delete location validation result</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <returns>Delete location validation result</returns>
        System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> CanDeleteLocationAsync(int id, int locationType);
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.2.4.0 (NJsonSchema v9.13.36.0 (Newtonsoft.Json v11.0.0.0))")]
    [Microsoft.AspNetCore.Mvc.Route("api")]
    public partial class LocationsController : Microsoft.AspNetCore.Mvc.ApiController
    {
        private ILocationsController implementation;
    
        public LocationsController(ILocationsController implementation)
        {
            this.implementation = implementation;
        }
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <param name="hierarchyId">The hierarchy identifier</param>
        /// <param name="locationStatuses">The array of selected status unique identifier will be among Active = 0, Inactive = 1, Archived = 2</param>
        /// <param name="limit">The amount of locations return per request</param>
        /// <param name="offset">The postion for first location to be returned in the collection</param>
        /// <response code="200">A list of locations founded using provided criterias</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Locations not found</response>
        /// <returns>A list of locations founded using provided criterias</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("locations")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Location>>> GetLocations(int? id, int? locationType, int? hierarchyId, System.Collections.Generic.IEnumerable<int> locationStatuses, int? limit, int? offset)
        {
            return this.implementation.GetLocationsAsync(id, locationType, hierarchyId, locationStatuses, limit, offset);
        }
    
        /// <param name="body">The updated location schema</param>
        /// <response code="200">The updated location</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <response code="422">Fail to update selected location</response>
        /// <returns>The updated location</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("locations")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Location>> UpdateLocation([Microsoft.AspNetCore.Mvc.FromBody] Location body)
        {
            return this.implementation.UpdateLocationAsync(body);
        }
    
        /// <param name="body">The new location schema</param>
        /// <response code="201">The new location</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="422">Fail to create new location</response>
        /// <returns>The new location</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("locations")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Location>> CreateLocation([Microsoft.AspNetCore.Mvc.FromBody] NewLocationParams body)
        {
            return this.implementation.CreateLocationAsync(body);
        }
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <response code="204">Location deletion result</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <response code="422">Fail to delete selected location</response>
        /// <returns>Location deletion result</returns>
        [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("locations")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> DeleteLocation(int id, int locationType)
        {
            return this.implementation.DeleteLocationAsync(id, locationType);
        }
    
        /// <param name="locationId">The location identifier</param>
        /// <param name="locationType">Location type of selected location. Group = 0, Location = 1</param>
        /// <response code="200">A location with provided identifier</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <returns>A location with provided identifier</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("locations/{locationId}")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Location>> GetLocationById(int locationId, int? locationType)
        {
            return this.implementation.GetLocationByIdAsync(locationId, locationType);
        }
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <param name="hierarchyId">The hierarchy identifier</param>
        /// <param name="locationStatuses">The array of selected statuses</param>
        /// <param name="levels">The number of level to traverse within hierarchy</param>
        /// <response code="200">A list of locations founded using provided criterias</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Locations not found</response>
        /// <returns>A list of locations founded using provided criterias</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("locations/traverse")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Location>>> GetTraversedLocations(int id, int locationType, int hierarchyId, System.Collections.Generic.IEnumerable<int> locationStatuses, int? levels)
        {
            return this.implementation.GetTraversedLocationsAsync(id, locationType, hierarchyId, locationStatuses, levels);
        }
    
        /// <response code="201">The updated location</response>
        /// <response code="400">Bad request</response>
        /// <response code="404">Location not found</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="422">Fail to update selected location</response>
        /// <returns>The updated location</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("locations/move")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> MoveLocation([Microsoft.AspNetCore.Mvc.FromBody] MovingLocationParams body)
        {
            return this.implementation.MoveLocationAsync(body);
        }
    
        /// <param name="body">The new location object</param>
        /// <response code="204">Create location validation result</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <returns>Create location validation result</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("locations/creationValidate")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> CanCreateLocation([Microsoft.AspNetCore.Mvc.FromBody] NewLocationParams body)
        {
            return this.implementation.CanCreateLocationAsync(body);
        }
    
        /// <param name="id">The location identifier</param>
        /// <param name="locationType">The location type will be among Group = 0, Location = 2</param>
        /// <response code="204">Delete location validation result</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">You do not have sufficient rights to this resource</response>
        /// <response code="404">Location not found</response>
        /// <returns>Delete location validation result</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("location/deletionValidate")]
            public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<bool>> CanDeleteLocation(int id, int locationType)
        {
            return this.implementation.CanDeleteLocationAsync(id, locationType);
        }
    
    }
    
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.36.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Location 
    {
        /// <summary>The location identifier</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Id { get; set; }
    
        /// <summary>The location name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>The location type will be among Group = 0, Location = 2</summary>
        [Newtonsoft.Json.JsonProperty("locationType", Required = Newtonsoft.Json.Required.Always)]
        public int LocationType { get; set; }
    
        /// <summary>The location status will be among Active = 0, Inactive = 1, Archived = 2</summary>
        [Newtonsoft.Json.JsonProperty("locationStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int LocationStatus { get; set; }
    
        /// <summary>The location parent identifiers</summary>
        [Newtonsoft.Json.JsonProperty("parentId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ParentId { get; set; }
    
        /// <summary>The hierarchy identifier</summary>
        [Newtonsoft.Json.JsonProperty("hierarchyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int HierarchyId { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static Location FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Location>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.36.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NewLocationParams 
    {
        /// <summary>The location name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>The location type will be among Group = 0, Location = 2</summary>
        [Newtonsoft.Json.JsonProperty("locationType", Required = Newtonsoft.Json.Required.Always)]
        public int LocationType { get; set; }
    
        /// <summary>The location status will be among Active = 0, Inactive = 1, Archived = 2</summary>
        [Newtonsoft.Json.JsonProperty("locationStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int LocationStatus { get; set; }
    
        /// <summary>The array of location parent identifiers</summary>
        [Newtonsoft.Json.JsonProperty("parentIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<int> ParentIds { get; set; }
    
        /// <summary>The hierarchy identifier</summary>
        [Newtonsoft.Json.JsonProperty("hierarchyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int HierarchyId { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static NewLocationParams FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<NewLocationParams>(data);
        }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.36.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class MovingLocationParams 
    {
        /// <summary>The location identifier</summary>
        [Newtonsoft.Json.JsonProperty("locationId", Required = Newtonsoft.Json.Required.Always)]
        public int LocationId { get; set; }
    
        /// <summary>The location type</summary>
        [Newtonsoft.Json.JsonProperty("locationType", Required = Newtonsoft.Json.Required.Always)]
        public int LocationType { get; set; }
    
        /// <summary>The location parent identifier</summary>
        [Newtonsoft.Json.JsonProperty("parentId", Required = Newtonsoft.Json.Required.Always)]
        public int ParentId { get; set; }
    
        public string ToJson() 
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    
        public static MovingLocationParams FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MovingLocationParams>(data);
        }
    
    }

    #pragma warning restore
}